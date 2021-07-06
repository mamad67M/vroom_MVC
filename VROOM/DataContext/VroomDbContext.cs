using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VROOM.Models;

namespace VROOM.DataContext
{
    public class VroomDbContext : DbContext
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options): base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

    }
}
