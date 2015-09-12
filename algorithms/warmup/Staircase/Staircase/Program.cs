using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var value = "";

            for (int i = 0; i < size; i++)
            {
                value += "#";
                Console.WriteLine(value.PadLeft(size));
            }
        }
    }
}
