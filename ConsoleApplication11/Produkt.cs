using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Produkt:ICloneable
    {
       public string nazwa;
       public double cenaJednostkowa;
       public double ilosc;

        public Produkt()
       {

       }
        public Produkt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }


        public void KopiujProdukt() //metoda z interfejsu nie musi byc statyczna
        {
            throw new NotImplementedException();
        }
    }
}
