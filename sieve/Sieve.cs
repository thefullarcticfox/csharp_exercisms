using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
            throw new ArgumentOutOfRangeException(nameof(limit), "limit must be higher than 2");

        var isPrime = new List<bool>(limit);
        isPrime.AddRange(Enumerable.Range(0, limit + 1).Select(_ => true));

        for (int i = 2; i <= limit; i++)
        for (int j = i * i; j <= limit; j += i)
            isPrime[j] = false;

        var primes = new List<int>();
        for (int i = 2; i <= limit; i++)
            if (isPrime[i])
                primes.Add(i);

        return primes.ToArray();
    }
}
