using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek
{
    public enum Departmanlar
    {
        Yazilim = 32, SistemAgUzmanligi, GrafikTasarim, Ingilicce, Muhasebe
    }//ilk elemanına 32 değeri atanınca bir sonraki +1 olarak ilerler
    internal class Personel
    {
        private string _adSoyad;
        public string AdSoyad { get { return _adSoyad; } set { _adSoyad = value; } }

        private Departmanlar _departman;
        public Departmanlar Departman { get { return _departman; } set { _departman = value; } }
    }
}
