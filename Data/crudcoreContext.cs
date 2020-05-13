using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudcore.Models;

namespace crudcore.Data
{
    public class crudcoreContext : DbContext
    {
        public crudcoreContext (DbContextOptions<crudcoreContext> options)
            : base(options)
        {
        }

        public DbSet<crudcore.Models.Employee> Employee { get; set; }
    }
}
