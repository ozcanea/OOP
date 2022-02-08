using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHashtable_Click(object sender, EventArgs e)
        {
            //Key-Value sistemiyle çalışır ve bu ikiliye obje türünde bir şey alabilir.büyük boyutlu koleksiyonlar için kullanılmaktadır.Hashtable, içerisindeki değerleri RAM'deki referans değerlerine göre sıralar.Key unique olmak zorundadır. 
            listBox1.Items.Clear();
            Hashtable anahtarDegerDizisi = new Hashtable();
            anahtarDegerDizisi.Add(7, "James Bond");
            anahtarDegerDizisi.Add(10, "Gheorghe Hagi");
            anahtarDegerDizisi.Add(23, "David Beckham");
            anahtarDegerDizisi.Add(55, "Sabri Sarıoğlu");

            if (anahtarDegerDizisi.ContainsKey(15))
            {
                MessageBox.Show("zaten var");
            }
            else
                anahtarDegerDizisi.Add(15, "Milan Baros");
            listBox1.Items.Clear();
            foreach (var item in anahtarDegerDizisi.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar: {0} - Değer: {1}", item, anahtarDegerDizisi[item]));
            }
            //anahtarDegerDizisi.ContainsValue("KontrolEdilecekDeger") boolean tipinde bir değer döndürür.
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            //FIFO yani first in first out mantığı ile çalışır. STACK yapısının ters mantığıdır.Kuyruğun sonuna bir eleman eklemek için Enqueue (),kuyruğun başına bir eleman çekmek iin Dequeue() methodları kullanılır.
            Queue queueObj = new Queue();
            queueObj.Enqueue("Selin");
            queueObj.Enqueue("EmreG");  
            queueObj.Enqueue("Sercan");
            queueObj.Enqueue("Çiçek");
            queueObj.Enqueue("Enes");

            while (queueObj.Count > 0)
            {
                listBox1.Items.Add(queueObj.Dequeue());
            }
        }

        private void btnHybridDictionary_Click(object sender, EventArgs e)
        {
            //!!!!!!!!!!! ÖNEMLİ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Hashtable ve ListDictionary mantığı gibi key-value mantığı ile çalışır.
            //Ancak MSDN'in söylemine göre eğer koleksiyonunuz küçükse (eleman sayısı 10 ve altındaysa) ListDictionary olarak davranır, eleman sayısı 10'un üzerine geçtiği anda kendini HashTable'e dondurur...
            //Koleksiyonunuzun büyüklüğüne göre yapacağınız doğru bir koleksiyon seçimi size performans olarak geri dönecektir.
            HybridDictionary anahtarDegerDizisi = new HybridDictionary();
            anahtarDegerDizisi.Add(1, "İstanbul");
            anahtarDegerDizisi.Add(2, "Ankara");
            anahtarDegerDizisi.Add(3, "İzmir");
            anahtarDegerDizisi.Add(4, "Bursa");
            anahtarDegerDizisi.Add(5, "Eskişehir");
            anahtarDegerDizisi.Add(6, "İzmit");
            anahtarDegerDizisi.Add(7, "Gebze");
            anahtarDegerDizisi.Add(8, "Karabük");
            anahtarDegerDizisi.Add(9, "Malatya");
            anahtarDegerDizisi.Add(10, "Şırnak");
            anahtarDegerDizisi.Add(11, "Adıyaman");
            anahtarDegerDizisi.Add(12, "Bolu");
            foreach (var item in anahtarDegerDizisi.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar: {0} - Değer: {1}", item, anahtarDegerDizisi[item]));
            }
        }

        private void btnListDictionary_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Hashtable gibi key-value mantığıyla çalışır ancak daha az gelişmiştir.
            ListDictionary anahtarDegerDizisi = new ListDictionary();
            anahtarDegerDizisi.Add(1, "İstanbul");
            anahtarDegerDizisi.Add(2, "Ankara");
            anahtarDegerDizisi.Add(3, "İzmir");
            anahtarDegerDizisi.Add(4, "Bursa");
            anahtarDegerDizisi.Add(5, "Eskişehir");
            anahtarDegerDizisi.Add(6, "İzmit");
            anahtarDegerDizisi.Add(7, "Gebze");
            anahtarDegerDizisi.Add(8, "Karabük");
            anahtarDegerDizisi.Add(9, "Malatya");
            anahtarDegerDizisi.Add(10, "Şırnak");
            anahtarDegerDizisi.Add(11, "Adıyaman");
            anahtarDegerDizisi.Add(12, "Bolu");
            foreach (var item in anahtarDegerDizisi.Keys)
            {
                listBox1.Items.Add(string.Format("Anahtar: {0} - Değer: {1}", item, anahtarDegerDizisi[item]));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1933, "Elektrik ve Elektronik Mühendisliği");
            sortedList.Add(1942, "Bilgisayar Mühendisliği");
            sortedList.Add(1955, "Mekatronik Mühendisliği");
            sortedList.Add(1953, "Makine Mühendisliği");

            // Veri girilişleri sırasına değil KEY sırasına göre getirir..!..

            foreach (string item in sortedList.Values)
            {
                listBox1.Items.Add(item);
            }

            // Listeyi Enumerator ile yazdırma...
            IDictionaryEnumerator dicEn = sortedList.GetEnumerator();

            while (dicEn.MoveNext())
            {
                listBox1.Items.Add(dicEn.Value);
            }
        }
    }
}
