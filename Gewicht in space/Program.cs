using System;

namespace Gewicht_in_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MijnGewicht = 64.4;

            double mercurius = 0.38*MijnGewicht;
            double venus = 0.91 * MijnGewicht;
            double aarde = 1.00 * MijnGewicht;
            double mars = 0.38 * MijnGewicht;
            double jupiter = 2.34 * MijnGewicht;
            double saturnus = 1.06 * MijnGewicht;
            double uranus = 0.92 * MijnGewicht;
            double neptunus = 1.19 * MijnGewicht;
            double pluto = 0.06 * MijnGewicht;

            Console.WriteLine($"Je weegt {mercurius}kg op mercurius");
            Console.WriteLine($"Je weegt {venus}kg op venus");
            Console.WriteLine($"Je weegt {aarde}kg op aarde");
            Console.WriteLine($"Je weegt {mars}kg op mars");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je weegt {jupiter}kg op mars");
            Console.ResetColor();

            Console.WriteLine($"Je weegt {saturnus}kg op saturnus");
            Console.WriteLine($"Je weegt {uranus}kg op uranus");
            Console.WriteLine($"Je weegt {neptunus}kg op neptunus");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je weegt {pluto}kg op pluto");
            Console.ResetColor();
        }   

    }
}
