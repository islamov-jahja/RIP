using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RipBackend.Models.User;

namespace RipBackend.Models
{
    public class CatalogOfCar : DbContext
    {
        public DbSet<User.User> User { get; set; }
        public DbSet<Reserve.Reserve> Reserve { get; set; }
        public DbSet<Car.Car> Car { get; set; }
        public DbSet<Model.Model> Model { get; set; }
        public DbSet<Carcase.Carcase> Carcase { get; set; }
        public DbSet<Marka.Marka> Mark { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Catalog;Integrated Security=True");
        }
    }
}
