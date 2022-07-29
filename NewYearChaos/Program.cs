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

/*
class Result
{


     // Complete the 'minimumBribes' function below.
     //
     // The function accepts INTEGER_ARRAY q as parameter.


    public static void minimumBribes(List<int> q)
    {
        // init a list of zeros of length q.Length
        int totalBribes = 0;
        int bribes = 0;
        for (var i = 0; i < q.Count; i++) {
            bribes = q[i] - (i + 1);
            if ( bribes > 2) {
                Console.WriteLine("Too chaotic");
                return;
            }
            totalBribes += Math.Max(bribes, 0);
        }
        Console.WriteLine($"{totalBribes}");
    }
}
*/

class Result
{


    // Complete the 'minimumBribes' function below.
    //
    // The function accepts INTEGER_ARRAY q as parameter.


    public static void minimumBribes(List<int> q)
    {
        int steps = 0;
        int temp;
        int bribes;

        for (var i = 0; i < q.Count; i++)
        {
            bribes = q[i] - (i + 1);
            if (bribes > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }
        for (int j = 0; j <= q.Count - 2; j++)
        {
            for (int i = 0; i <= q.Count - 2; i++)
            {
                if (q[i] > q[i + 1])
                {
                    temp = q[i + 1];
                    q[i + 1] = q[i];
                    q[i] = temp;
                    steps++;
                }
            }
        }
        Console.WriteLine($"{steps}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> lists = new List<List<int>>();
        lists.Add(new List<int>() { 2, 1, 5, 3, 4 }); // 3
        lists.Add(new List<int>() { 2, 5, 1, 3, 4 }); // Too chaotic
        lists.Add(new List<int>() { 5, 1, 2, 3, 7, 8, 6, 4 }); // Too chaotic
        lists.Add(new List<int>() { 1, 2, 5, 3, 7, 8, 6, 4 }); // 7
        lists.Add(new List<int>() { 1, 2, 5, 3, 4, 7, 8, 6 }); // 4

        foreach (var list in lists)
        {

            Result.minimumBribes(list);
        }
    }
}
