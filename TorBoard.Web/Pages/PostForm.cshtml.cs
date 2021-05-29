using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorBoard.Core.Models;
using TorBoard.Core.Services;

namespace TorBoard.Web.Pages
{
	public class PostForm : PageModel
	{
		private readonly PostService _postService;

		public PostForm(PostService postService)
		{
			_postService = postService;
		}

		[BindProperty] public Post Post { get; set; }

		public async Task<IActionResult> OnPost()
		{
			Post.Id = Guid.NewGuid();
			Post.CreationDate = DateTime.Now;
			if (!ModelState.IsValid)
			{
				return Page();
			}

			await _postService.AddPostAsync(Post);
			return RedirectToPage("Index");
		}
	}
}
