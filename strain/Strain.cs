using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var res = new List<T>();
        foreach(var elem in collection)
            if (predicate(elem))
                res.Add(elem);
        return res;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var res = new List<T>();
        foreach(var elem in collection)
            if (!predicate(elem))
                res.Add(elem);
        return res;
    }
}
