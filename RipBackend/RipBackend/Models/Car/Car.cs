using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipBackend.Models.Car
{
    public class Car
    {
        public int id { get; set; }
        public int idMark { get; set; }
        public int idModel { get; set; }
        public int idCarcase { get; set; }
        public DateTime dateOfCreation { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public decimal price { get; set; }
        public string pathToImage { get; set; }
    }
}
