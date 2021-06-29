using System;
using System.ComponentModel.DataAnnotations;

namespace TorBoard.Core.Models
{
	public class Post : DbEntity
	{
		[Required] public DateTime CreationDate { get; set; }

		[Required(ErrorMessage = "You have to write at least 10 characters.")]
		[MinLength(10, ErrorMessage = "You have to write at least 10 characters.")]
		public string Content { get; set; }

#nullable enable
		public Guid? ParentId { get; set; }
#nullable disable
	}
}
