using System;
using System.Diagnostics;
using System.Linq;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r) => r.Expreal(realNumber);
}

public struct RationalNumber
{
    private static int getGCD(int[] numbers) => numbers.Aggregate(getGCD);
    private static int getGCD(int a, int b) => b == 0 ? a : getGCD(b, a % b);

    private int _a, _b;

    public RationalNumber(int numerator, int denominator)
    {
        _a = numerator;
        _b = denominator;
    }

    //  r1 + r2 = a1/b1 + a2/b2 = (a1 * b2 + a2 * b1) / (b1 * b2)
    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2) {
        return new RationalNumber(r1._a * r2._b + r2._a * r1._b, r1._b * r2._b).Reduce();
    }

    //  r1 - r2 = a1/b1 - a2/b2 = (a1 * b2 - a2 * b1) / (b1 * b2)
    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2) {
        return new RationalNumber(r1._a * r2._b - r2._a * r1._b, r1._b * r2._b).Reduce();
    }

    //  r1 * r2 = (a1 * a2) / (b1 * b2)
    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2) =>
        new RationalNumber(r1._a * r2._a, r1._b * r2._b).Reduce();

    //  r1 / r2 = (a1 * b2) / (a2 * b1) if a2 * b1 is not zero
    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        if (r2._a * r1._b == 0)
            throw new DivideByZeroException("division by zero");
        return new RationalNumber(r1._a * r2._b, r2._a * r1._b).Reduce();
    }

    public RationalNumber Abs() => new RationalNumber(Math.Abs(_a), Math.Abs(_b));

    public RationalNumber Reduce()
    {
        int gcd = Math.Abs(getGCD(new int[]{_a, _b}));
        if (_b < 0)
            return new RationalNumber(-_a / gcd, -_b / gcd);
        return new RationalNumber(_a / gcd, _b / gcd);
    }

    public RationalNumber Exprational(int power)
    {
        if (power < 0)
            return new RationalNumber(Convert.ToInt32(Math.Pow(_b, -power)), Convert.ToInt32(Math.Pow(_a, -power))).Reduce();
        return new RationalNumber(Convert.ToInt32(Math.Pow(_a, power)), Convert.ToInt32(Math.Pow(_b, power))).Reduce();
    }

    public double Expreal(int baseNumber) => Math.Pow(baseNumber, Convert.ToDouble(_a) / Convert.ToDouble(_b));
}
