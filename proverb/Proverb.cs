using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var res = new List<string>();
        for (int i = 0; i + 1 < subjects.Length; i++)
            res.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        if (subjects.Length > 0)
            res.Add($"And all for the want of a {subjects[0]}.");
        return res.ToArray();
    }
}
