using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RipBackend.Models.Model
{
    public class ModelContext : CatalogOfCar
    {
        public DbSet<Model> Models { get; set; }
    }
}
