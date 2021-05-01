using System;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static readonly List<KeyValuePair<int, string>> _roman_digits =
        new List<KeyValuePair<int, string>>{
        new KeyValuePair<int, string>(1000, "M"),	new KeyValuePair<int, string>(900, "CM"),
        new KeyValuePair<int, string>(500, "D"),	new KeyValuePair<int, string>(400, "CD"),
        new KeyValuePair<int, string>(100, "C"),	new KeyValuePair<int, string>(90, "XC"),
        new KeyValuePair<int, string>(50, "L"),		new KeyValuePair<int, string>(40, "XL"),
        new KeyValuePair<int, string>(10, "X"),		new KeyValuePair<int, string>(9, "IX"),
        new KeyValuePair<int, string>(5, "V"),		new KeyValuePair<int, string>(4, "IV"),
        new KeyValuePair<int, string>(1, "I")
    };

    public static string ToRoman(this int value)
    {
        if (value < 0)
            throw new ArgumentException("less than zero");
        string res = "";
        foreach (var digit in _roman_digits) {
            while (value / digit.Key != 0) {
                value -= digit.Key;
                res += digit.Value;
            }
        }
        return res;
    }
}
