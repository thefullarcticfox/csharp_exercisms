using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    private static string[] _colors =
        new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static string Label(string[] colors)
    {
        int ohms = 0;

        for (int i = 0; i < 2 && i < colors.Length; i++) {
            ohms *= 10;
            ohms += Array.IndexOf(_colors, colors[i]);
        }

        for (int i = 0; i < Array.IndexOf(_colors, colors[2]); i++)
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
