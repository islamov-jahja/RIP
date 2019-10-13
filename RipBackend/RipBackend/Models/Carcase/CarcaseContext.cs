using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RipBackend.Models.Carcase
{
    public class CarcaseContext : CatalogOfCar
    {
        public DbSet<Carcase> Carcases { get; set; }
    }
}
