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

class Solution
{
    static void Main(string[] args)
    {
        // input is 2 List<int>()
        // first and second lists
        var list1 = new List<int>() { 1, 2, 3 };
        var list2 = new List<int>() { 3, 4 };
        // expected output is 1, 2, 3, 3, 4
        var output = new List<int>();
        foreach (var item in list1)
        {
            output.Add(item);
        }

        foreach (var item in list2)
        {
            output.Add(item);
        }

        output = output.OrderBy(item => item).ToList();
        foreach (var item in output)
        {
            Console.WriteLine($"{item}");
        }
    }
}
