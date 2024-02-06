using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF4._Act5.Act6
{
    internal class Car : WheeledVehicle
    {
        private string fuel;

        public Car(string _name, int _year, int _kms, bool _motor, int _wheels, string _fuel) : base(_name, _year, _kms, _motor, _wheels)
        {
            fuel = _fuel;
        }
        public string Fuel { get; set; }
    }
}
