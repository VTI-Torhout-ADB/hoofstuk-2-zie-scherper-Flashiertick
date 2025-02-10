namespace Kill_Death_ratio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kills = 44.0;
            double deaths = 9.0;
            double kd = (kills / deaths);

            Console.WriteLine($"Je k/d-ratio is {kd}");
        }
    }
}
