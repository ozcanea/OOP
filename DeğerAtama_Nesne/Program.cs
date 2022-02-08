using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeğerAtama_Nesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirSinif a =new BirSinif();
            BirSinif b =new BirSinif();
            a.j = 11;
            Console.WriteLine(a.j);//11 basar
            Console.WriteLine(b.j);//10 basar
            //Console.WriteLine(a.i); i yi görmez
            BirSinif.i = 30;
            Console.WriteLine(BirSinif.i);

            /////////////////////////////////////////
            IkiSinif c = new IkiSinif("ekin");//ekin basar
            IkiSinif d = new IkiSinif();//hello ekin basar
            UcSinif e = new UcSinif();
            Console.WriteLine(e);//UcSinif basar

        }
    }
}

class BirSinif
{
    public static int i = 10;
    public int j = 10;
}

class IkiSinif
{
    public IkiSinif()
    {
        Console.WriteLine("Hello Ekin");
    }
    public IkiSinif(string text)
    {
        Console.WriteLine(text);
    }
}
class UcSinif
{
    public UcSinif()
    {

    }
    string _name = "Ekin";//name fieldına ulaşacak property yok
}