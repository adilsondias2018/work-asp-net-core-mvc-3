using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc01.Models
{
    public class SalesWebMvc01Context : DbContext
    {
        public SalesWebMvc01Context (DbContextOptions<SalesWebMvc01Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc01.Models.Departaments> Departaments { get; set; }
    }
}
