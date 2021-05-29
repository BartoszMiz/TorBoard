using System;

namespace TorBoard.Core.Models
{
	public class Post : DbEntity
	{
		public DateTime CreationDate { get; set; }
		public string Content { get; set; }
	}
}
