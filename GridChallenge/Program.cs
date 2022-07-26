using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gridChallenge' function below.
     *String.Concat(str.OrderBy(c => c))

     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        var sortedGrid = new List<string>();
        foreach (var row in grid) {
            sortedGrid.Add(String.Concat(row.OrderBy(c => c)));
        }

        for (var i = 0; i < grid[0].Length - 1; i++) {
            var sortedRow = sortedGrid[i];
            var nextSortedRow = sortedGrid[i + 1];
            for (var j = 0; j < sortedRow.Length; j++) {
                if (sortedRow[j] > nextSortedRow[j]) {
                    return "NO";
                }
            }
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var grid = new List<string>() { "ade",
                                        "cba",
                                        "efg" };

        string result = Result.gridChallenge(grid);

        Console.WriteLine(result);
    }
}
