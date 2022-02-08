using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Drum : Instrument
    {
        public override string Play()//Abstract Classın içindki abstract methodların inherit alındığı yerde kullanılması zorunlu
        {
           return "Drum Sound";
        }
    }
}
