using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Inheritance_Polimorphism
{
    internal class Apple:BaseClass
    {
        public Apple()
        {
            this.Brand = "Apple";
        }
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\iphone.waw"))
            {
                player.PlaySync();
            }
        }
    }
}
