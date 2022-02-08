using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    internal class Sınav
    {
        private double _geçmeNotu;
        public double GeçmeNotu 
        {
            get
            {
                return _geçmeNotu;
            }
            set
            {
                if (value < 50)
                {
                    MessageBox.Show("Geçme Notu 50'den Düşük Olamaz!Geçme Notu 50 Olarak Ayarlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _geçmeNotu = 50;
                }
                else
                    _geçmeNotu = value;
            }
        }
        public string Name { get; }
        public Sınav()
        {
            Name = "Biyoloji";
        }
      

    }
}
