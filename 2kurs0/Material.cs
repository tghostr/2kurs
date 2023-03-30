using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kurs0
{
    class Material
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string Number { get; set; }

        public Material(string mname, string munit, string mprice, string mnumber)
        {
            Name = mname;
            Unit = munit;
            Price = mprice;
            Number = mnumber;
        }
    }
}
