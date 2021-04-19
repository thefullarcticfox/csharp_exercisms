using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        char[] arr = word.ToLower().ToCharArray();
        Array.Sort(arr);
        for (int i = 1; i < arr.Length; i++)
            if (Char.IsLetter(arr[i]) && arr[i - 1] == arr[i])
                return false;
        return true;
    }
}
