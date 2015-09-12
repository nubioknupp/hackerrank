using System;

namespace time_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(time.ToString("HH:mm:ss"));
        }
    }
}
