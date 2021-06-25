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

		public Post CurrentPost { get; set; }
		[BindProperty] public Post NewPost { get; set; }

		public async Task<IActionResult> OnGet(Guid? postId)
		{
			if (postId != null) CurrentPost = await _postService.GetPostAsync((Guid) postId);
			return Page();
		}

		public async Task<IActionResult> OnPost(Guid? postId)
		{
			NewPost.Id = Guid.NewGuid();
			NewPost.CreationDate = DateTime.Now;
			if (postId != null)
				NewPost.ReplyTo = await _postService.GetPostAsync((Guid) postId);

			if (!ModelState.IsValid)
			{
				return Page();
			}

			await _postService.AddPostAsync(NewPost);
			return RedirectToPage("Index");
		}
	}
}
