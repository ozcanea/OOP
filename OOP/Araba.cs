using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Araba
    {
            public string Marka { get; set; }
            public string Model { get; set; }
            public int Motor { get; set; }

            public Araba(string Marka, string Model, int Motor)
            {
                this.Motor = Motor;
                this.Marka = Marka;
                this.Model = Model;
            }
            public Araba()
            {
                Marka = "Mercedes";
            }
    }
}
