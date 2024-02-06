using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF4._Act5.Act6
{
    internal class WheeledVehicle : Vehicle
    {
        private bool motor;
        private int wheels;

        public WheeledVehicle(string _name, int _year, int _kms, bool _motor, int _wheels) : base(_name, _year, _kms)
        {
            motor = _motor;
            wheels = _wheels;
        }

        public bool Motor { get; set; }
        public int Wheels
        {
            get; set;
        }
    }
}
