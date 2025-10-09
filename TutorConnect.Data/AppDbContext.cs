using Microsoft.EntityFrameworkCore;
using TutorConnect.Core.Entities;
using TutorConnect.Core.Interfaces;
using TutorConnect.Data.Repositories;
using TutorConnect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorConnect.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Define your DbSets here, for example:
        // public DbSet<Student> Students { get; set; }
    }
}
