using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int number = Convert.ToInt32(string.Format("{0}{1}", i, j));
                    int reverse = Convert.ToInt32(string.Format("{0}{1}", j, i));
                    if (i != j && number < reverse && number < 89)
                    {
                        Console.Write($"{number:D2}, ");
                    }
                    else if (number == 89)
                    {
                        Console.WriteLine($"{number:D2}");
                    }
                }
            }
        }
    }
}
