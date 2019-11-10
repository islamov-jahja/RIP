using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipBackend.Models.Reserve
{
    public class Reserve
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idCar { get; set; }
    }
}
