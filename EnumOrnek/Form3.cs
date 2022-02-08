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
    public partial class Form3 : Form
    {
        enum Sehirler
        {
            Ankara = 6,
            İstanbul = 34,
            Adana = 1,
            İzmir = 35,
            Malatya = 44
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            int enumDegeri = int.Parse(txtEnum.Text);
            //Convert.ToInt32(txtEnum.Text);
            Sehirler sehir = (Sehirler)enumDegeri;

            MessageBox.Show(sehir.ToString());
        }

        private void btnKontrolluEnum_Click(object sender, EventArgs e)
        {
            int enumDegeri = int.Parse(txtEnum.Text);

            if (Enum.IsDefined(typeof(Sehirler), enumDegeri))//contains gibi
            {
                Sehirler sehir = (Sehirler)enumDegeri;
                MessageBox.Show("Girdiğiniz şehir değerinin karşılığı: " + sehir);
            }
            else
            {
                MessageBox.Show("Girdiğiniz değere göre böyle bir şehir elimizde mevcut değildir:)");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (string sehir in Enum.GetNames(typeof(Sehirler)))
            {
                listBox1.Items.Add(sehir + "-" + Convert.ToInt32(Enum.Parse(typeof(Sehirler), sehir)));
            }
        }
    }
}
