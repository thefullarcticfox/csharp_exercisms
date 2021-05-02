using System;
using System.Collections.Generic;

public static class House
{
    private static readonly List<KeyValuePair<string, string>> _whatThatPairs =
        new List<KeyValuePair<string, string>>{
            new KeyValuePair<string, string>("house", "Jack built"),
            new KeyValuePair<string, string>("malt", "lay in"),
            new KeyValuePair<string, string>("rat", "ate"),
            new KeyValuePair<string, string>("cat", "killed"),
            new KeyValuePair<string, string>("dog", "worried"),
            new KeyValuePair<string, string>("cow with the crumpled horn", "tossed"),
            new KeyValuePair<string, string>("maiden all forlorn", "milked"),
            new KeyValuePair<string, string>("man all tattered and torn", "kissed"),
            new KeyValuePair<string, string>("priest all shaven and shorn", "married"),
            new KeyValuePair<string, string>("rooster that crowed in the morn", "woke"),
            new KeyValuePair<string, string>("farmer sowing his corn", "kept"),
            new KeyValuePair<string, string>("horse and the hound and the horn", "belonged to")
        };

    public static string Recite(int verseNumber)
    {
        if (verseNumber < 1 || verseNumber > 12)
            throw new ArgumentException("verseNumber can't be less than 1 or more than 12");
        string res = $"This is the {_whatThatPairs[--verseNumber].Key}";
        while (verseNumber >= 0) {
            res += $" that {_whatThatPairs[verseNumber].Value}";
            if (verseNumber-- != 0)
                res += $" the {_whatThatPairs[verseNumber].Key}";
        }
        return res + '.';
    }

    public static string Recite(int startVerse, int endVerse)
    {
        if (startVerse > endVerse)
            throw new ArgumentException("invalid verse range");
        string res = "";
        while (startVerse <= endVerse)
            res += $"{Recite(startVerse++)}{(startVerse > endVerse ? "" : "\n")}";
        return res;
    }
}
