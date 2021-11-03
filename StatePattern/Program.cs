using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car tesla = new Car() {Name = "特斯拉 Model S"};
            tesla.Run();
            tesla.SpeedUp();
            tesla.SpeedDown();
            tesla.Stop();

            Console.WriteLine();
        }
    }
}
