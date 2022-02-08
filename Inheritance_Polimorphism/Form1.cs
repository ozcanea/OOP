using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Polimorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.Id = 1;
            nokia.Model = "NNN666";
            // nokia.CallSound();

            MessageBox.Show("Telefonun IDsi: " + nokia.Id + " Markası: " + nokia.Brand + " Modeli: " + nokia.Model);

            MessageBox.Show($"Telefonun Markası: {nokia.Brand}");
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.Id = 2;
            samsung.Model = "NNN666";
            // samsung.CallSound();

            MessageBox.Show("Telefonun IDsi: " + samsung.Id + " Markası: " + samsung.Brand + " Modeli: " + samsung.Model);
        }

        private void BtnApple_Click(object sender, EventArgs e)
        {
            Apple iphone = new Apple();
            iphone.Id = 3;
            iphone.Model = "NNN666";
            // samsung.CallSound();

            MessageBox.Show("Telefonun IDsi: " + iphone.Id + " Markası: " + iphone.Brand + " Modeli: " + iphone.Model);
        }
    }
}
