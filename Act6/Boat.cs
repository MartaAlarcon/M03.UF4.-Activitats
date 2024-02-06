using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF4._Act5.Act6
{
    internal class Boat : Vehicle
    {
        private string type;

        public Boat(string _name, int _year, int _kms, string _type) : base(_name, _year, _kms)
        {
            type = _type;
        }

        public string Type { get; set; }


    }
}
