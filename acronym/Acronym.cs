using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] split = phrase.Split(" -.,".ToCharArray());

        string res = "";
        for (int i = 0; i < split.Length; i++)
            for (int j = 0; j < split[i].Length; j++)
                if (Char.IsLetter(split[i][j])) {
                    res += split[i][j];
                    break;
                }
        return res.ToUpper();
    }
}
