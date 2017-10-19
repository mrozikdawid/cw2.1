using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszykJana = new Koszyk();
            koszykJana.DodajeProdukt("Jabłko", 3);
            koszykJana.DodajeProdukt("Piwo", 5);
            koszykJana.DodajeProdukt("Wodka", 20);
            koszykJana.Ilosc();
            koszykJana.Suma();


            Console.ReadKey();
        }
    }
}
