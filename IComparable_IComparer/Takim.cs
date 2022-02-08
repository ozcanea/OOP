using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_IComparer
{
    //Interface'ler hep I ile başlar ve abstract classın içindeki abstract methodlara benzerlikleri bağlandıkları classlarda kullanılmak zorundadırlar. Farkları birden fazla Class'tan inheritance alamazsın ama birden fazla Interface'i bu şekide bağşayabilirsin
    internal class Takim : IComparable<Takim>
    {
        public string Ad { get; set; }
        public byte Puan { get; set; }
        public sbyte Averaj { get; set; }

        public int CompareTo(Takim other)
        {
            if (this.Puan < other.Puan) return 1;
            else if (this.Puan > other.Puan) return -1;
            else return 0;
        }
        public override string ToString()
        {
            return this.Ad;
        }
    }
    class PuaniBuyuktenKucugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return x.Puan.CompareTo(y.Puan);
        }
    }
    class PuaniKucuktenBuyugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return -(x.Puan.CompareTo(y.Puan));
        }
    }
    class AverajaGoreBuyuktenKucugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            if (x.Averaj < y.Averaj) return 1;
            else if (x.Averaj > y.Averaj) return -1;
            else return 0;
        }
    }
    class AverajaGoreKucuktenBuyugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            AverajaGoreBuyuktenKucugeSirala sira = new AverajaGoreBuyuktenKucugeSirala();
            return -(sira.Compare(x, y));
        }
    }
    class AdaGoreBuyuktenKucugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return x.Ad.CompareTo(y.Ad);
        }
    }
    class AdaGoreKucuktenBuyugeSirala : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            AdaGoreBuyuktenKucugeSirala sira = new AdaGoreBuyuktenKucugeSirala();
            return -(sira.Compare(x, y));
        }
    }
}
