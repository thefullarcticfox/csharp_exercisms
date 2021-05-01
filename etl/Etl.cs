using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var   res = new Dictionary<string, int>();
        foreach (var pair in old)
            foreach (string elem in pair.Value)
                res.Add(elem.ToLower(), pair.Key);
        return res;
    }
}
