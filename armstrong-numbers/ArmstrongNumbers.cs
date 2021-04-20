using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = Array.ConvertAll(number.ToString().ToCharArray(), x => (int)x - '0');

        int sum = 0;
        foreach (int digit in digits) {
            int power = 1;
            for (int i = 0; i < digits.Length; i++)
                power *= digit;
            sum += power;
        }
        return number == sum;
    }
}
