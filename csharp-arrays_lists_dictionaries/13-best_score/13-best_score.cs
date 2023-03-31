using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxKey = "None";
        int maxValue = 0;
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxValue)
            {
                maxKey = entry.Key;
                maxValue = entry.Value;
            }
        }
        return maxKey;
    }
}
