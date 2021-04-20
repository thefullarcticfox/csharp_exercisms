using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    private static readonly Dictionary<string, int> _resistors = new Dictionary<string, int>() {
        { "black", 0 }, { "brown", 1 }, { "red", 2 }, { "orange", 3 },
        { "yellow", 4 }, { "green", 5 }, { "blue", 6 }, { "violet", 7 },
        { "grey", 8 }, { "white", 9 }
    };

    public static string Label(string[] colors)
    {
        int ohms = 0;

        for (int i = 0; i < 2 && i < colors.Length; i++) {
            ohms *= 10;
            ohms += _resistors[colors[i]];
        }

        for (int i = 0; i < _resistors[colors[2]]; i++)
            ohms *= 10;

        string prefix = "";
        if (ohms % 1000000000 == 0) {
            ohms /= 1000000000;
            prefix = "giga";
        } else if (ohms % 1000000 == 0) {
            ohms /= 1000000;
            prefix = "mega";
        } else if (ohms % 1000 == 0) {
            ohms /= 1000;
            prefix = "kilo";
        }

        return $"{ohms} {prefix}ohms";
    }
}
