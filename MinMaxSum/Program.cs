var arr = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };
long min = arr.Min();
long max = arr.Max();
long minSum = arr.Sum(x => (long)x) - max;
long maxSum = arr.Sum(x => (long)x) - min;
Console.WriteLine($"{minSum} {maxSum}");
