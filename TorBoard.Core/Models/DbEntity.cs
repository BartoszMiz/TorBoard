using System;
using System.ComponentModel.DataAnnotations;

namespace TorBoard.Core.Models
{
	public abstract class DbEntity
	{
		[Key] public Guid Id { get; set; }
	}
}