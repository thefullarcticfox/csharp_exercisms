using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> _resistors = new Dictionary<string, int>() {
        { "black", 0 }, { "brown", 1 }, { "red", 2 }, { "orange", 3 },
        { "yellow", 4 }, { "green", 5 }, { "blue", 6 }, { "violet", 7 },
        { "grey", 8 }, { "white", 9 }
    };
    public static int Value(string[] colors)
    {
        int res = 0;
        for (int i = 0; i < 2 && i < colors.Length; i++) {
            res *= 10;
            res += _resistors[colors[i]];
        }
        return res;
    }
}
