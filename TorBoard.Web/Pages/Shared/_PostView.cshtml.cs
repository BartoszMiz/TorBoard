using Microsoft.AspNetCore.Mvc.RazorPages;
using TorBoard.Core.Models;

namespace TorBoard.Web.Pages.Shared
{
	public class PostView : PageModel
	{
		public PostView(Post post)
		{
			Post = post;
		}

		public Post Post { get; }
		public Post NewPost { get; }
	}
}
