using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Aplikacja
    {
        public char klawisz;
        char WczytajKlawisz()
        {
            Console.WriteLine("Dzien dobry!");
            Console.WriteLine("Co chcesz zrobic? Nacisnij odpowiedni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - kopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartosc koszyka");
            Console.WriteLine("S - pokaz sume do zaplaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz znac wczesniej numer na liscie");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - zakoncz dzialanie programu");
            klawisz=char.Parse(Console.ReadLine());
            return klawisz;
            //Console.ReadKey();
        }

        void WykonajDzialanie()
        {
            switch(klawisz)
            {
                case ('P'): Koszyk.DodajProdukt("Jabłko",3,4);  //błędne parametry powinna być instrukcja by pobrac od uzytkownika parametry
                    break;
                case('K'): //Produkt.KopiujProdukt();
                    break;
                case('Z'):
                    break;
                case('S'):
                    break;
                case ('X'):
                    break;
                case ('W'):
                    break;
                case ('N'):
                    break;
                case ('E'):
                    break;
                default: Console.WriteLine("Blad programu!");
                    break; //tu potrzebny break
            }
        }
    }
}
