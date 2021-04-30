using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string>	codons = new List<string>();
		for (int i = 0; i + 3 <= strand.Length; i += 3)
			codons.Add(strand.Substring(i, 3));

        List<string>	res = new List<string>();
		foreach (string codon in codons) {
			if (codon == "AUG")
				res.Add("Methionine");
			else if (codon == "UUU" || codon == "UUC")
				res.Add("Phenylalanine");
			else if (codon == "UUA" || codon == "UUG")
				res.Add("Leucine");
			else if (codon == "UCU" || codon == "UCC" || codon == "UCA" || codon == "UCG")
				res.Add("Serine");
			else if (codon == "UAU" || codon == "UAC")
				res.Add("Tyrosine");
			else if (codon == "UGU" || codon == "UGC")
				res.Add("Cysteine");
			else if (codon == "UGG")
				res.Add("Tryptophan");
			else if (codon == "UAA" || codon == "UAG" || codon == "UGA")
				break;
		}
		return res.ToArray();
    }
}
