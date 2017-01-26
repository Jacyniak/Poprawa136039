using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa136039
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pojazd> pojazdy = new List<Pojazd>();
            pojazdy.Add(new Osobowy("BMW", "X5", 50, true, false));
            pojazdy.Add(new Autobus("MAN", "Lion's Regio", 150, 48));
            pojazdy.Add(new Osobowy("Dodge", "Challenger", 78, true, false));
            pojazdy.Add(new Autobus("Sindbad", "WR4", 259, 58));
            pojazdy.Add(new Osobowy("Fiat", "Panda", 35, true, false));
            pojazdy.Add(new Autobus("MAN", "Deli", 89, 30));
            pojazdy.Add(new Osobowy("Opel", "Omega", 47, true, true));
            pojazdy.Add(new Autobus("Sindbad", "Bore", 200, 52));
            pojazdy.Add(new Osobowy("Audi", "A3", 64, false, false));
            pojazdy.Add(new Autobus("MAN", "B40", 120, 38));



            for (int i = pojazdy.Count - 1; i>=0; i-=2 )
            {
                Console.WriteLine(pojazdy[i].ToString());
            }
            Console.WriteLine();

            new Wypozyczalnia(15, 53);
            new Wypozyczalnia(40, 80);
            new Wypozyczalnia(10, 15);
            

            for (int i = pojazdy.Count - 2; i >= 0; i -= 2)
            {
                Console.WriteLine(pojazdy[i].ToString());
                Console.WriteLine("Koszt: " + pojazdy[i].ObliczKoszt(7).ToString());  
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
