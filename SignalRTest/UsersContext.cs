using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalRTest.Models;

namespace SignalRTest
{
    public class UsersContext : DbContext
    {
        public DbSet<RegisterModel> Users { get; set; }

        public UsersContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
