var arr = new List<int>() {-4, 3, -9, 0, 4, 1};
int positive = 0;
int negative = 0;
int zero = 0;
foreach (int i in arr)
{
    if (i > 0) positive++;
    if (i < 0) negative++;
    if (i == 0) zero++;
}
int total = arr.Count();
Console.WriteLine($"{(float)positive / total:F6}");
Console.WriteLine($"{(float)negative / total:F6}");
Console.WriteLine($"{(float)zero / total:F6}");
