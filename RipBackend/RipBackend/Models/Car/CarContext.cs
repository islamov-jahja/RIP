using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RipBackend.Models.Car
{
    public class CarContext : CatalogOfCar
    {
        public DbSet<Car> Cars { get; set; }
    }
}
