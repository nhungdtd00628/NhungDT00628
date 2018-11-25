using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EXAM2.Models;

namespace EXAM2.Models
{
    public class EXAM2Context : DbContext
    {
        public EXAM2Context (DbContextOptions<EXAM2Context> options)
            : base(options)
        {
        }

        public DbSet<EXAM2.Models.Category> Category { get; set; }

        public DbSet<EXAM2.Models.Product> Product { get; set; }
    }
}
