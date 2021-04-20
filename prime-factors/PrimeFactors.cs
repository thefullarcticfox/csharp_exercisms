using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long>  factors = new List<long>();

        while (number % 2 == 0) {
            factors.Add(2);
            number /= 2;
        }

        for (int i = 3; i <= number; i += 2) {
            while (number % i == 0) {
                factors.Add(i);
                number /= i;
            }
        }

        return factors.ToArray();
    }
}
