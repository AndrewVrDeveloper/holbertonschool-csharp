using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        List<int> numbers = new List<int>(size);
        int i;
        for (i = 0; i < size; i++)
        {
            if (i < size - 1)
            {
                numbers.Add(i);
                Console.Write($"{i} ");
            }
            else
            {
                numbers.Add(i);
                Console.WriteLine($"{i}");
            }
        }
        return numbers;
    }
}
