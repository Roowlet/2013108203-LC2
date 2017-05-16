using _2013108203_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013108203_PER
{
    public class _2013108203DbContext : DbContext
    {
        public DbSet<Administrativo> Administrativos { get; set; }
    }
}
