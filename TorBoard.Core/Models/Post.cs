using System;
using System.ComponentModel.DataAnnotations;

namespace TorBoard.Core.Models
{
	public class Post : DbEntity
	{
		[Required] public DateTime CreationDate { get; set; }
		[Required] [MinLength(10)] public string Content { get; set; }
	}
}
