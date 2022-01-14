using Microsoft.EntityFrameworkCore;
using SAINA.Models;

namespace Lubes.DBContext
{
	public class ApplicationDBContext : DbContext
	{
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Particulars> Particulars { get; set; }
        public DbSet<Receipts> Receipts { get; set; }
        public DbSet<Log_in> Log_in { get; set; }


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
			: base(options)
		{
		}
	}
}