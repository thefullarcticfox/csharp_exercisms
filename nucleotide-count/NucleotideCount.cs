using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        sequence = sequence.ToUpper();
        var nucleotides = new Dictionary<char, int>{{'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}};
        foreach (char nuc in sequence) {
            if (!nucleotides.ContainsKey(nuc))
                throw new ArgumentException($"{nuc} is an invalid nucleotide");
            ++nucleotides[nuc];
        }
        return nucleotides;
    }
}
