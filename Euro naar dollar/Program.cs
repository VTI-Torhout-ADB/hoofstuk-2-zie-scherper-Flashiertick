namespace Euro_naar_dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BedragInEuro = 78.55;
            double BedragInDollar = BedragInEuro * 1.04;
            Console.WriteLine($"{BedragInEuro}EUR is gelijk aan {BedragInDollar}USD");
        }
    }
}
