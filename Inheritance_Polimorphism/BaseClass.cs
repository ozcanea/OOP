using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;//sound için

namespace Inheritance_Polimorphism
{
    internal class BaseClass
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\default.waw"))
            {
                player.PlaySync();
            }
        }
    }
}
