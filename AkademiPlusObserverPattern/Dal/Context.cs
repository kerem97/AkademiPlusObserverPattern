using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlusObserverPattern.Dal
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1MSR6CD\\SQLEXPRESS;initial catalog=AkademiPlusObserver;integrated security=true");

        }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }
}
