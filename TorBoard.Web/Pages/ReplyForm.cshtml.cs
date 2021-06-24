using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorBoard.Core.Models;
using TorBoard.Core.Services;

namespace TorBoard.Web.Pages
{
	public class ReplyForm : PageModel
	{
		private readonly PostService _postService;

		public ReplyForm(PostService postService)
		{
			_postService = postService;
		}

		public Post Post { get; set; }
		[BindProperty] public Post Reply { get; set; }

		[TempData] public Guid PostId { get; set; }

		public async Task<IActionResult> OnGet(Guid postId)
		{
			Post = await _postService.GetPostAsync(postId);
			PostId = postId;
			return Page();
		}

		public async Task<IActionResult> OnPost()
		{
			Reply.Id = Guid.NewGuid();
			Reply.CreationDate = DateTime.Now;
			Reply.ReplyTo = await _postService.GetPostAsync(PostId);
			if (!ModelState.IsValid) return Page();

			await _postService.AddPostAsync(Reply);
			return RedirectToPage("Index");
		}
	}
}
