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
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int SuperDigit(string n, int k)
    {
        var input = "";
        for (var i = 0; i < k; i++)
        {
            input += n;
        }
        var sum = 0;
        // while input.length > 1
        while (input.Length > 1) {
            // then sum all digits
            sum = input.Select(x => int.Parse(x.ToString())).Sum();
            // reassign to input as a string
            input = sum.ToString();
        }

        return Convert.ToInt32(input);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string n = "9875";

        int k = 4;

        int result = Result.SuperDigit(n, k);
        Console.WriteLine(result);
    }
}
