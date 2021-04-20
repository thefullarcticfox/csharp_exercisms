using System;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2)
            throw new ArgumentException("Bad base");

        List<int> outputDigits = new List<int>(){0};
        foreach (int inputDigit in inputDigits) {
            if (inputDigit < 0 || inputDigit >= inputBase)
                throw new ArgumentException("Bad digit");

            int carry = inputDigit;
            for (int i = 0; i < outputDigits.Count; i++) {
                int d = outputDigits[i] * inputBase + carry;
                outputDigits[i] = d % outputBase;
                carry = d / outputBase;
            }

            while (carry > 0) {
                outputDigits.Add(carry % outputBase);
                carry /= outputBase;
            }
        }

        outputDigits.Reverse();
        return outputDigits.ToArray();
    }
}
