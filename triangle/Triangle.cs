using System;
using System.Linq;

public static class Triangle
{
    private static bool AlmostEqual(double x, double y,
                                    double AbsEpsilon = Double.Epsilon,
                                    double RelEpsilon = Double.Epsilon) {
        double  diff = Math.Abs(x - y);
        if (diff <= AbsEpsilon)
            return true;
        return diff <= Math.Max(Math.Abs(x), Math.Abs(y)) * RelEpsilon;
    }

    private static bool IsInvalidTriangle(double x, double y, double z) {
        if (x <= 0.0 || y <= 0.0 || z <= 0.0 || z > x + y || x > y + z || y > x + z)
			return true;
        return false;
    }

    private static int GetEqualSidesCount(double x, double y, double z) {
        return (new bool[]{AlmostEqual(x, y), AlmostEqual(y, z), AlmostEqual(x, z)}).Count(x => x);
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (IsInvalidTriangle(side1, side2, side3))
            return false;
        return GetEqualSidesCount(side1, side2, side3) == 0;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        if (IsInvalidTriangle(side1, side2, side3))
            return false;
        return GetEqualSidesCount(side1, side2, side3) > 0;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        if (IsInvalidTriangle(side1, side2, side3))
            return false;
        return GetEqualSidesCount(side1, side2, side3) > 1;
    }
}
