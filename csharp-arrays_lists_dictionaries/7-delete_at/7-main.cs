using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {98, 42, 972, -1, 1024};

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

         List<int> otherList = List.DeleteAt(myList, 1);

        foreach (int i in otherList)
            Console.WriteLine(i);
    }
}