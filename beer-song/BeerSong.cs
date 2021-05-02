using System;

public static class BeerSong
{
    private static string spellBottles(int bottles, bool cap = false) =>
        $"{(bottles == 0 ? $"{(cap ? "N" : 'n')}o more" : bottles)} bottle{(bottles == 1 ? "" : "s")}";

    public static string Recite(int startBottles, int takeDown)
    {
        string res = "";
        while (--takeDown >= 0) {
            res += $"{spellBottles(startBottles, true)} of beer on the wall, " +
                $"{spellBottles(startBottles)} of beer.\n";
            if (startBottles == 0) {
                res += "Go to the store and buy some more, ";
                startBottles = 100;
            }
            else
                res += $"Take {(startBottles == 1 ? "it" : "one")} down and pass it around, ";
            res += $"{spellBottles(--startBottles)} of beer on the wall.";
            if (takeDown > 0)
                res += "\n\n";
        }
        return res;
    }
}
