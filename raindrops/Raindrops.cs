using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string	res = "";
		if (number % 3 == 0)
			res += "Pling";
		if (number % 5 == 0)
			res += "Plang";
		if (number % 7 == 0)
			res += "Plong";
		if (res.Length == 0)
			res = number.ToString();
		return res;
    }
}
