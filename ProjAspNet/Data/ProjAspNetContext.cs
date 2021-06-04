
using Microsoft.EntityFrameworkCore;
using ProjAspNet.Models;

namespace ProjAspNet.Data
{
    public class ProjAspNetContext : DbContext
    {
        public ProjAspNetContext (DbContextOptions<ProjAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord{ get; set; }
    }
}
