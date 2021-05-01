using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        sequence.ToUpper();
        if (sequence.Any(nuc => !("ACGT".Contains(nuc))))
            throw new ArgumentException("invalid nucleotide");
        return new Dictionary<char, int>{
            {'A', sequence.Count(nuc => nuc == 'A')},
            {'C', sequence.Count(nuc => nuc == 'C')},
            {'G', sequence.Count(nuc => nuc == 'G')},
            {'T', sequence.Count(nuc => nuc == 'T')}
        };
    }

    /*  another option is using foreach and TryGet
        sequence.ToUpper();
        var nucleotides = new Dictionary<char, int>{{'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}};
        foreach (char nuc in sequence) {
            if (!nucleotides.TryGetValue(nuc, out int val))
                throw new ArgumentException($"{nuc} is an invalid nucleotide");
            ++nucleotides[nuc];
        }
        return nucleotides;
    */
}
