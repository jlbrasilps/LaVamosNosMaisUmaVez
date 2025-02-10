using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaSallesWeb.Models;

namespace LojaSallesWeb.Data
{
    public class LojaSallesWebContext : DbContext
    {
        public LojaSallesWebContext (DbContextOptions<LojaSallesWebContext> options)
            : base(options)
        {
        }

        public DbSet<LojaSallesWeb.Models.Department> Department { get; set; } = default!;
    }
}
