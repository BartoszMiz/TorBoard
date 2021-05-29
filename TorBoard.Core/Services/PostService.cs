using System.Collections.Generic;
using System.Threading.Tasks;
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

		public IEnumerable<Post> GetPosts()
		{
			return _dbContext.Posts;
		}

		public async Task AddPostAsync(Post post)
		{
			await _dbContext.Posts.AddAsync(post);
			await _dbContext.SaveChangesAsync();
		}
	}
}
