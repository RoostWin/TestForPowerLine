namespace TestForPowerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Truck megabibika = new Truck(20, 15, 70, 560);

            double test = megabibika.GetPathDistanceWithLoad();

            TimeSpan vremechko = megabibika.GetTravelTime(400);

            Console.WriteLine(test);
        }
    }
}