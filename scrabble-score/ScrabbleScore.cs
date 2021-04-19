using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int     res = 0;
		int[]   scrabblePoints = {
			1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1,
			1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
		for (int i = 0; i < input.Length; i++)
			res += scrabblePoints[Char.ToLower(input[i]) - 'a'];
		return res;
    }
}
