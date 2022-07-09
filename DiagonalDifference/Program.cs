var matrix = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 9, 8, 9 }
};

var leftDiagonal = 0;
var rightDiagonal = 0;

for (var row = 0; row < matrix.Count(); row++)
{
    leftDiagonal += matrix[row][row];
    rightDiagonal += matrix[row][matrix.Count() - 1 - row];
}

// expected output is |15 - 17| = 2
Console.WriteLine(Math.Abs(rightDiagonal - leftDiagonal));
