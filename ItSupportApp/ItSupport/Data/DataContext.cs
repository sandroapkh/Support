using ItSupport.Entites;
using Microsoft.EntityFrameworkCore;

namespace ItSupport.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
		{

		}
        public DbSet<AppUser> Users { get; set; }
    }
}
