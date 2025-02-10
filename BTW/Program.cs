using System.Net.WebSockets;

namespace BTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs = 20;
            const double BTW = 0.21;
            double prijsBTW = (prijs * BTW)+prijs;
            Console.WriteLine($"de prijs is {prijs} euro zonder BTW. En met BTW is het {prijsBTW}");
        }
    }
}
