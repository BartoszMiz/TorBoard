using Microsoft.EntityFrameworkCore;
using TorBoard.Core.Models;

namespace TorBoard.Core
{
	public class AppDbContext : DbContext
	{
		public DbSet<Post> Posts { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { }
	}
}
