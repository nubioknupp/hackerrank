using System;
using System.Numerics;

namespace extra_long_factorials
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            BigInteger x = 1;

            for (var i = 1; i <= n; i++)
            {
                x = x * i;
            }

            Console.WriteLine(x);
        }

    }
}
