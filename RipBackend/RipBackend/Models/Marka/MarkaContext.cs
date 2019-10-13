using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RipBackend.Models.Marka
{
    public class MarkaContext : CatalogOfCar
    {
        public DbSet<Marka> Marks { get; set; }
    }
}
