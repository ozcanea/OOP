using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceAndValueTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Ogrenci
        {
            private string _ad;
            public string Ad
            {
                get { return _ad; }
                set { _ad = value; }
            }

            private string _soyad;
            public string Soyad
            {
                get { return _soyad; }
                set { _soyad = value; }
            }
        }
        struct Student
        {
            private string _firstName;
            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            private string _lastName;
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
        }
        //Metodlar
        int Topla(ref int sayi1)
        {
            int sonuc = 0;
            int sayi2 = 15;
            sayi1 += 10;
            sonuc = sayi1 + sayi2;
            MessageBox.Show("A (metot içi): " + sayi1);
            return sayi1;
        }
        string MetinGetir()
        {
            string metinlerce = "Hello World";
            return metinlerce;
        }
        string MetinGetir(ref string kullanicidanGelenMetin)
        {
            string metinlerce = "Hello World2";
            metinlerce = kullanicidanGelenMetin;
            return metinlerce;
        }
        string MetinGetir(string metin)
        {
            string metinlerce = "Hello World3";
            metinlerce = metin;
            metinlerce = "metot içinde tanımlanan metin";

            return metinlerce;
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Bilge";
            ogr.Soyad = "Selin";

            MessageBox.Show("ÖĞRENCİ ogr: " + ogr.Ad + " " + ogr.Soyad);
            MessageBox.Show(ogr.GetHashCode().ToString());

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Ad = "Ekin";
            ogr2.Soyad = "ÖZCAN";

            MessageBox.Show("ÖĞRENCİ ogr2: " + ogr2.Ad + " " + ogr2.Soyad);
            MessageBox.Show(ogr2.GetHashCode().ToString());// hash'de tutuldukları adres

            ////////////////////////////////
            ogr2 = ogr;//bu işlemden sonra hashde aynı yeri refere etmiş olacaklarından birisinde değişiklik yapmak hepsini etkiler
            MessageBox.Show("ÖĞRENCİ ogr2: " + ogr2.Ad + " " + ogr2.Soyad);


            Ogrenci ogr3 = ogr;
            ogr3.Ad = "Bilge Olmayan";
            MessageBox.Show(ogr3.GetHashCode().ToString());

            MessageBox.Show("ÖĞRENCİ ogr: " + ogr.Ad + " " + ogr.Soyad);
            MessageBox.Show("ÖĞRENCİ ogr2: " + ogr2.Ad + " " + ogr2.Soyad);
            MessageBox.Show("ÖĞRENCİ ogr3: " + ogr3.Ad + " " + ogr3.Soyad);

            MessageBox.Show(ogr.GetHashCode() + "\n" + ogr2.GetHashCode() + "\n" + ogr3.GetHashCode());

            //////////////////////////////////////

            int[] sayilar = { 12, 14, 16 };
            int[] sayilar2 = sayilar;

            sayilar2[1] = 24;
            MessageBox.Show(sayilar[1].ToString());
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.FirstName = "Bilge";
            stu.LastName = "Selin";

            Student stu2 = stu;
            stu2.FirstName = "Selocan";

            MessageBox.Show(stu.FirstName);


            string metin = "Selamlarcaa...";


            //MessageBox.Show(MetinGetir());
            //string s2 = MessageBox.Show(MetinGetir(ref metin));
            //string s3 = MessageBox.Show(metin);
            //string s4 = MessageBox.Show(MetinGetir("BilgeSelin"));

            string s1 = MetinGetir();
            string s2 = MetinGetir(ref metin);
            string s3 = metin;
            string s4 = MetinGetir("BilgeSelin");


            MessageBox.Show(s1 + "eklenen1");
            MessageBox.Show(s2 + "eklenen1");
            MessageBox.Show(s3 + "eklenen1");
            MessageBox.Show(s4 + "eklenen1");


            // -------------------------------------------

            int a = 5;
            int b = a;
            int sonuc = 100;


            //MessageBox.Show("A: "+a+"- B: "+b);


            //b += 10;
            //MessageBox.Show("Yeni A: " +a);
            //MessageBox.Show("Yeni B: "+b);

            MessageBox.Show("Metot değişiklik öncesi gelen A: " + a);
            Topla(ref a);//15
            MessageBox.Show(a.ToString());//15 yazar
            // MessageBox.Show("RETURN SAYI: " + Topla(ref a));
            a = Topla(ref a);
            MessageBox.Show("A (ana program): " + a);
        }
    }
}
