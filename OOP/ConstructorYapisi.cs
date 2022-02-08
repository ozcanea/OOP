using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    
    public partial class ConstructorYapisi : Form
    {
        public ConstructorYapisi()
        {
            InitializeComponent();
        }

        private void ConstructorYapisi_Load(object sender, EventArgs e)
        {
            Araba arb = new Araba(); // Böyle oluşturursak arb.Marka Mercedes olarak tanımlanır.

            Araba arb2 = new Araba("Fiat", "Punto", 1600);

            MessageBox.Show(arb.Marka);
            MessageBox.Show(arb.Marka+" "+ arb2.Model+" "+ arb2.Motor);
        }
    }

}
