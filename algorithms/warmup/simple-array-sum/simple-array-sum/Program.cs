using System;

namespace simple_array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var numbers = (Console.ReadLine() + "").Split();
            var sun = 0;


            for (int i = 0; i < size; i++)
            {
                sun += Convert.ToInt32(numbers[i]);
            }

            Console.WriteLine(sun);
        }
    }
}
