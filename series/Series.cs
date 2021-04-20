using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength < 1 || numbers.Length < sliceLength)
            throw new ArgumentException("Bad arguments");

        List<string>    res = new List<string>();
        for (int i = 0; i + sliceLength <= numbers.Length; i++)
            res.Add(numbers.Substring(i, sliceLength));
        return res.ToArray();
    }
}
