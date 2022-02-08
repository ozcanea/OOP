using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polimorphism
{
    internal class Samsung:BaseClass
    {
        public Samsung()
        {
            this.Brand = "Samsung";
        }
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\samsung.waw"))
            {
                player.PlaySync();
            }
        }
}
