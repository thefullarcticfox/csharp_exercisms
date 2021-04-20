using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static readonly Dictionary<string, int> _resistors = new Dictionary<string, int>() {
        { "black", 0 }, { "brown", 1 }, { "red", 2 }, { "orange", 3 },
        { "yellow", 4 }, { "green", 5 }, { "blue", 6 }, { "violet", 7 },
        { "grey", 8 }, { "white", 9 }
    };
    public static int ColorCode(string color)
    {
        return _resistors[color];
    }

    public static string[] Colors()
    {
        string[] res = new string[_resistors.Count];

        int i = 0;
        foreach (var pair in _resistors)
            res[i++] = pair.Key;

        return res;
    }
}
