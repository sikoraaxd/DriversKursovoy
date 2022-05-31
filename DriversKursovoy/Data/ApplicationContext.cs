using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DriversKursovoy.Data;

namespace DriversKursovoy
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driving> Drivings { get; set; }
        public DbSet<PathNumber> PathNumbers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Drivers;Username=postgres;Password=alexgeniuss56455285");
        }
    }
}
