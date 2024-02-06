using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF4._Act5.Act6
{
    public class Vehicle
    {
        private string name;
        private int year;
        private int kms;

        public Vehicle(string _name, int _year, int _kms)
        {
            name = _name;
            year = _year;
            kms = _kms;
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public int Kms { get; set; }

    }
}
