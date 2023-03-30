using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kurs0
{
    class Equipment
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string Number { get; set; }

        public Equipment(string ename, string eunit, string eprice, string enumber)
        {
            Name = ename;
            Unit = eunit;
            Price = eprice;
            Number = enumber;
        }
    }
}
