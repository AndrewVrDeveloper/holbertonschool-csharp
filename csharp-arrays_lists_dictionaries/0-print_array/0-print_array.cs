using System;
using System.Collections;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] tempArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            tempArray[i] = i;
            Console.Write($"{tempArray[i]} ");
        }

        Console.WriteLine();
        return tempArray;
    }
}
