using System;

namespace diagonal_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[size, size];
            var diagA = 0;
            var diagB = 0;

            for (int i = 0; i < size; i++)
            {
                var temp = (Console.ReadLine() + "").Split();

                for (int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            for (int i = 0; i < size; i++)
            {
                diagA += matrix[i, i];
                diagB += matrix[i, (size - 1) - i];
            }

            Console.WriteLine(Math.Abs(diagA - diagB));

        }
    }
}
