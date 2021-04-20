using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        if (sum < 0)
            throw new ArgumentException("Bad sum");

        List<(int a, int b, int c)>   res = new List<(int a, int b, int c)>();

        for (int a = 1; a < sum - 2 * a - 1; a++) {
            for (int b = a + 1; b < sum - a - b; b++) {
                int c = sum - a - b;
                if (a * a + b * b == c * c)
                    res.Add((a, b, c));
            }
        }
        return res;
    }
}
