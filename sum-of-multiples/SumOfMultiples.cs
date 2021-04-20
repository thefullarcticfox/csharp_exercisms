using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int>    foundmultiples = new HashSet<int>();
        foreach (int num in multiples)
            for (int i = 1; num > 0 && num * i < max; i++)
                foundmultiples.Add(num * i);
        return foundmultiples.Sum();
    }
}
