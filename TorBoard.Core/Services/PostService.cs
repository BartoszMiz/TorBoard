using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TorBoard.Core.Models;

namespace TorBoard.Core.Services
{
	public class PostService
	{
		private readonly AppDbContext _dbContext;

		public PostService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Post[]> GetPostsAsync()
		{
			return await _dbContext.Posts.ToArrayAsync();
		}

		public async Task AddPostAsync(Post post)
		{
			// post.Content = TextProcessingService.ConvertText(post.Content);
			await _dbContext.Posts.AddAsync(post);
			await _dbContext.SaveChangesAsync();
		}
	}
}
