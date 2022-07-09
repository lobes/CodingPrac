var matrix = new List<List<int>>
{
    new List<int> { 112, 42, 83, 119 },
    new List<int> { 56, 125, 56, 49 },
    new List<int> { 15, 78, 101, 43 },
    new List<int> { 62, 98, 114, 108 }
};

var n = matrix.Count;
var maxValues = new List<int>();
var sum = 0;
for (var i = 0; i < n / 2; i++) 
{
    for (var j = 0; j < n / 2; j++)
    {
        var tempList = new List<int>
        {
        matrix[i][j],
        matrix[i][n - j - 1],
        matrix[n - i - 1][j],
        matrix[n - i - 1][n - j - 1] };
        maxValues.Add(tempList.Max());
        sum += tempList.Max();
    }
}
Console.WriteLine(String.Join(" ", maxValues) + "\n");

Console.WriteLine(sum);
