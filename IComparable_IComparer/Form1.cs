using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable_IComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Takim> takimlar = new List<Takim>();
        private void Form1_Load(object sender, EventArgs e)
        {
            takimlar.Add(new Takim { Ad = "GalataSaray", Averaj = 56, Puan = 78 });
            takimlar.Add(new Takim { Ad = "Beşiktaş", Averaj = 34, Puan = 54 });
            takimlar.Add(new Takim { Ad = "Fenerbahçe", Averaj = 25, Puan = 32 });
            takimlar.Add(new Takim { Ad = "Trabzonspor", Averaj = 48, Puan = 74 });
            takimlar.Add(new Takim { Ad = "Eskişehirspor", Averaj = 32, Puan = 41 });
            takimlar.Add(new Takim { Ad = "İstanbul Büyükşehir Belediyespor", Averaj = 14, Puan = 26 });
            takimlar.Add(new Takim { Ad = "Bursaspor", Averaj = 36, Puan = 48 });
            takimlar.Add(new Takim { Ad = "Antalyaspor", Averaj = 21, Puan = 24 });
            takimlar.Add(new Takim { Ad = "Mersin İdman Yurdu", Averaj = -5, Puan = 6 });
            takimlar.Add(new Takim { Ad = "Göztepe", Averaj = 14, Puan = 26 });

            takimlar.Sort();
            ListeDoldur();
        }
        void ListeDoldur()
        {
            listView1.Items.Clear();
            int siralama = 1;

            foreach (var takim in takimlar)
            {
                ListViewItem li = new ListViewItem(siralama.ToString());
                li.SubItems.Add(takim.Ad);
                li.SubItems.Add(takim.Averaj.ToString());
                li.SubItems.Add(takim.Puan.ToString());
                siralama++;
                listView1.Items.Add(li);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        bool puanBuyuktenKucugeMi = true;
        bool averajBuyuktenKucugeMi = true;
        bool adBuyuktenKucugeMi = true;//işin raconunda genelde false atayıp sonradan true döndürmek var ama biz böyle yaptık.

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    if (adBuyuktenKucugeMi)
                    {
                        takimlar.Sort(new AdaGoreKucuktenBuyugeSirala());
                        adBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        takimlar.Sort(new AdaGoreBuyuktenKucugeSirala());
                        adBuyuktenKucugeMi = true;
                    }
                    break;

                case 2:
                    if (averajBuyuktenKucugeMi)
                    {
                        takimlar.Sort(new AverajaGoreKucuktenBuyugeSirala());
                        averajBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        takimlar.Sort(new AverajaGoreBuyuktenKucugeSirala());
                        averajBuyuktenKucugeMi = true;
                    }
                    break;

                case 3:
                    if (puanBuyuktenKucugeMi)
                    {
                        takimlar.Sort(new PuaniKucuktenBuyugeSirala());
                        puanBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        takimlar.Sort(new PuaniBuyuktenKucugeSirala());
                        puanBuyuktenKucugeMi = true;
                    }
                    break;

                default:
                    MessageBox.Show("UYMADI !! ");
                    break;
            }
            ListeDoldur();
        }
    }
}
