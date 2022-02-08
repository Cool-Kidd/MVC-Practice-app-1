using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Application_1.Models;

namespace MVC_Application_1.Data
{
    public class MVC_Application_1Context : DbContext
    {
        public MVC_Application_1Context (DbContextOptions<MVC_Application_1Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Info>()
                .HasKey(c => new { c.PersonID, c.TelNo, c.CellNo});
        }

        public DbSet<MVC_Application_1.Models.Person> Person { get; set; }

        public DbSet<MVC_Application_1.Models.Info> Info { get; set; }
    }
}
