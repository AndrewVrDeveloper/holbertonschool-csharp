using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> listFromDict = new List<string>(myDict.Keys);
        listFromDict.Sort();

        foreach (string key in listFromDict)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
