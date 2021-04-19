using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException("Zero or not a natural number");
        if (number == 1)
            return Classification.Deficient;
        int divsum = 1;
        for (int i = 2; i < number; i++)
            if (number % i == 0)
                divsum += i;
        if (divsum > number)
            return Classification.Abundant;
        if (divsum < number)
            return Classification.Deficient;
        return Classification.Perfect;
    }
}
