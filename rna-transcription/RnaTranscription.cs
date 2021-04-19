using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string res = "";
        foreach (char c in nucleotide) {
            if (c == 'G')
                res += 'C';
            if (c == 'C')
                res += 'G';
            if (c == 'T')
                res += 'A';
            if (c == 'A')
                res += 'U';
        }
        return res;
    }
}
