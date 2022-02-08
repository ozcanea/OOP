using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumOrnek
{
    /// <summary>
    /// ArgumentException
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        enum Sehirler :byte
        {
            Bursa = 12, Ankara = 55, İzmir = 11, İstanbul, Eskişehir
        }


        private void button2_Click(object sender, EventArgs e)
        {
            byte seciliIndex = Convert.ToByte( Enum.Parse(typeof(Sehirler), listBox1.Text));
            MessageBox.Show("Seçili şehrin indexi: " + seciliIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte seciliIndex = (byte)Enum.Parse(typeof(Sehirler), listBox2.Text);
            MessageBox.Show("Seçili şehrin indexi: " + seciliIndex);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //listBox1.Items.AddRange(Enum.GetNames(typeof(Sehirler)));

            //enum Sehirler : byte {Bursa = 12, Ankara = 55, İzmir = 11 , İstanbul, Eskişehir}
            foreach (Sehirler sehir in Enum.GetValues(typeof(Sehirler)))
            {
                //listBox2.Items.Add(sehir);
                listBox1.Items.Add(sehir );
            }

            foreach (string sehir in Enum.GetNames(typeof(Sehirler)))
            {
                listBox2.Items.Add(sehir);
            }
        }
    }
}
