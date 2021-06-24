using AspNetCore.ReCaptcha;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorBoard.Core.Models;

namespace TorBoard.Web.Pages.Shared
{
	[ValidateReCaptcha(ErrorMessage = "Please verify you are not a robot.")]
	public class PostView : PageModel
	{
		public PostView(Post post)
		{
			Post = post;
		}

		public Post Post { get; }
	}
}
