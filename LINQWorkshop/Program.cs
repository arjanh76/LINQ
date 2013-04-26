using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Voorbeeld2();
        }

        static void Voorbeeld2()
        {
            // LINQ blabl blbalablblabl
            var namen = new List<string> { "Asterix", "Obelix", "Idefix", "Ambiorix" };
            Console.WriteLine("Geef de beginletter(s): ");
            var beginVanNaam = Console.ReadLine();
            var gevondenNamen = namen.Where(naam => naam.StartsWith(beginVanNaam));
            foreach (var naam in gevondenNamen)
                Console.WriteLine(naam);

            Console.ReadLine();
        }

        
    }
}
