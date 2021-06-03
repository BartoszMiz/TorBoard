using Microsoft.AspNetCore.Mvc.RazorPages;
using TorBoard.Core.Models;

namespace TorBoard.Web.Pages.Shared
{
	public class PostView : PageModel
	{
		public Post Post { get; }

		public PostView(Post post)
		{
			Post = post;
		}
	}
}
