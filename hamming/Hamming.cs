using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("inequal lengths of strands");
        return firstStrand.Zip(secondStrand).Count(charPair => charPair.First != charPair.Second);
    }
}
