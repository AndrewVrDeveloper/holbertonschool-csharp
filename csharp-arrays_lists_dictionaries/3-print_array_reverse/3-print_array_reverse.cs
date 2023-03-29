using System;
using System.Text;

class Array
{
    public static void Reverse(int[] array)
    {
        var sb = new StringBuilder();
        if (array != null)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    sb.Append(array[i]).Append(" ");
                }
                else
                {
                    sb.Append(array[i]);
                }
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
