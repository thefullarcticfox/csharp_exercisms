using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || digits.Length < span)
            throw new ArgumentException("Bad arguments");

        int res = 0;
        for (int i = 0; i + span <= digits.Length; i++) {
            string slice = digits.Substring(i, span);
            int product = 1;
            foreach (char c in slice) {
                if (!Char.IsDigit(c))
                    throw new ArgumentException("Not a digit in digits");
                product *= (c - '0');
            }
            if (res < product)
                res = product;
        }

        return res;
    }
}
