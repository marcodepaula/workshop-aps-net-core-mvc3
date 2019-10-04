using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc3.Models
{
    public class SalesWebMvc3Context : DbContext
    {
        public SalesWebMvc3Context (DbContextOptions<SalesWebMvc3Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc3.Models.Department> Department { get; set; }
    }
}
