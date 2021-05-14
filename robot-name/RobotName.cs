using System;
using System.Collections.Generic;

public class Robot
{
    private string _name;

    private static List<string> _prevNames = new List<string>(){""};
    private static Random _rng = new Random();

    private static string generateName() {
        string res = "";
        while (_prevNames.Contains(res)) {
            res = "";
            while (res.Length < 2)
                res += Convert.ToChar('A' + _rng.Next('Z' - 'A' + 1));
            while (res.Length < 5)
                res += _rng.Next(10);
        }
        _prevNames.Add(res);
        return res;
    }

    public Robot() => _name = generateName();

    public string Name
    {
        get => _name;
    }

    public void Reset()
    {
        _name = generateName();
    }
}
