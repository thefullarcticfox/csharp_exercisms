using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>>  res = new List<List<int>>();

        for (int i = 0; i < rows; i++) {
            List<int>  row = new List<int>();

            for (int j = 0; j <= i; j++) {
                if (j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(res[i - 1][j - 1] + res[i - 1][j]);
            }
            res.Add(row);
        }
        return res;
    }
}
