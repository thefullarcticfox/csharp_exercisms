using System;
using System.Collections.Generic;

public static class Darts
{
    private static readonly KeyValuePair<double, int>[]   _squareDistScorePairs = new KeyValuePair<double, int>[]
    {
        new KeyValuePair<double, int>(1.0, 10),
        new KeyValuePair<double, int>(25.0, 5),
        new KeyValuePair<double, int>(100.0, 1),
    };

    private static bool AlmostEqual(double x, double y,
                                    double AbsEpsilon = Double.Epsilon,
                                    double RelEpsilon = Double.Epsilon) {
        double  diff = Math.Abs(x - y);
        if (diff <= AbsEpsilon)
            return true;
        return diff <= Math.Max(Math.Abs(x), Math.Abs(y)) * RelEpsilon;
    }

    public static int Score(double x, double y)
    {
        double  dist = x * x + y * y;
        foreach (var score in _squareDistScorePairs)
            if (dist < score.Key || AlmostEqual(dist, score.Key))
                return score.Value;
        return 0;
    }
}
