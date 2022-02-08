using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Guitar : Instrument
    {
        public override string Play()
        {
            return "Guitar Sound";
        }
    }
}
