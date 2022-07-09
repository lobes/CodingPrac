var arr = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
var result = arr.GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key);
Console.WriteLine(result);
