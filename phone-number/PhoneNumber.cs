using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string  res = new string(phoneNumber.Where(Char.IsDigit).ToArray());
        if (res.Length < 10 || res.Length > 11)
            throw new ArgumentException("Invalid number length");
        if (res.Length > 10) {
            if (res[0] != '1')
                throw new ArgumentException("Invalid country code");
            res = res.Remove(0, 1);
        }
        if (res[0] < '2')
            throw new ArgumentException("Bad area code");
        if (res[3] < '2')
            throw new ArgumentException("Bad exchange code");
        return res;
    }
}
