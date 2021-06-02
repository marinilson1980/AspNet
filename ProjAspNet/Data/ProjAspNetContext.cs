using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjAspNet.Models
{
    public class ProjAspNetContext : DbContext
    {
        public ProjAspNetContext (DbContextOptions<ProjAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<ProjAspNet.Models.Departament> Departament { get; set; }
    }
}
