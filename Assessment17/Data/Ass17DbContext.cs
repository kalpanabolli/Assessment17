using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment17.Model;

namespace Assessment17.Data
{
    public class Ass17DbContext : DbContext
    {
        public Ass17DbContext (DbContextOptions<Ass17DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment17.Model.Movie> Movie { get; set; } = default!;
    }
}
