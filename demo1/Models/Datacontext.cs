using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace demo1.Models
{
    public class Datacontext : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usercs> Usercs { get; set; }

        public Datacontext(DbContextOptions<Datacontext> options) : base(options) { }

    }
}
