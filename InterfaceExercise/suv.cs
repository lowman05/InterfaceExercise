using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany 
    {
        public int Price { get; set; }
        public int CargoSize { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }
}
