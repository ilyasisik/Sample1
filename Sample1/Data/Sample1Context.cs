using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample1.Models
{
    public class Sample1Context : DbContext
    {
        public Sample1Context (DbContextOptions<Sample1Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Sample1.Models.Employee> Employee { get; set; }
    }
}
