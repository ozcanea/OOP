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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personeller = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPersonelDepartmani.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));//ComboBox'a atarken Addrange ile atıyoruz.Listede nasıl hepsini döndürmek istediğimizde foreach kullanıp hepsini tek tek atıyorsak aynı olaya denk geliyor.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.AdSoyad = txtPersonelAdi.Text;
            personel.Departman = (Departmanlar)Enum.Parse(typeof(Departmanlar), cmbPersonelDepartmani.Text);

            personeller.Add(personel);

            foreach (var personell in personeller)
            {
                MessageBox.Show("Adı: " + personell.AdSoyad + " Departman: " + personell.Departman);
            }
        }
    }
}
