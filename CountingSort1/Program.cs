var arr = new List<int> { 0, 0, 1, 1, 3, 2, 1 };
var freqArray = new List<int>(new int[100]);

for (var i = 0; i < arr.Count; i++) 
{
    freqArray[arr[i]] += 1;
}

Console.WriteLine(String.Join(" ", freqArray) + "\n");

/* bonus round:

var sorted = new List<int>();

for (var i = 0; i < freqArray.Count(); i++)
{
    if (freqArray[i] != 0)
    {
        for (var j = 1; j <= freqArray[i]; j++)
        {
            sorted.Add(i);
        }
    
    }
}

Console.WriteLine(String.Join(" ", sorted));

*/