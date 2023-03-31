using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {

        Dictionary<string, int> myNewDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> entry in myDict)
        {
            myNewDict.Add(entry.Key, entry.Value * 2);
        }

        return myNewDict;
    }
}
