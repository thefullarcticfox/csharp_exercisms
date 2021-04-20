using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static string[] _colors =
        new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int Value(string[] colors)
    {
        int res = 0;
        for (int i = 0; i < 2 && i < colors.Length; i++) {
            res *= 10;
            res += Array.IndexOf(_colors, colors[i]);
        }
        return res;
    }
}
