// given a list of odd size number of ints
// find the median value

var arr = new List<int> { 5, 3, 1, 2, 4 };
arr.Sort();
var count = arr.Count();
var midIndex = Convert.ToInt32((float)count / 2 - 0.5);
Console.WriteLine(arr[midIndex]);
