using System;

namespace a_very_big_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var numbers = (Console.ReadLine() + "").Split();
            decimal sun = 0;


            for (int i = 0; i < size; i++)
            {
                sun += decimal.Parse(numbers[i]);
            }

            Console.WriteLine(sun);
        }
    }
}
