/*
 * Input: string `s`
 * Return: index of char to remove (or -1 if `s` is already a palindrome, or cannot be made)
 * Length of `s`: 1 <= s <= 10^5 + 5
 * All chars are ascii[a-z]
 * 
 * Sample In:
 * STDIN   Function
-----   --------
3       q = 3
aaab    s = 'aaab' (first query)
baa     s = 'baa'  (second query)
aaa     s = 'aaa'  (third query)

 * Sample Out:
 * 3
 * 0
 * -1
 */
var inputArray = new string[] {"quyjjdcgsvvsgcdjjyq",
"hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh",
"fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf",
"bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb",
"fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf",
"mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdyqmgfwrpceakceblfhfeibmm",
"tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt",
"lhrxvssvxrhl",
"prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp",
"kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk",
"asdf"
};

for (var i = 0; i < inputArray.Length; i++)
{
    var index = -1;
    var s = inputArray[i];

    if (s.SequenceEqual(s.Reverse()))
    {
        Console.WriteLine($"Success at Index: {index}\n Already Palindrome: \n{s}");
        continue;
    }
    string modifiedString;

    for (var j = 0; j < s.Length; j++)
    {
        modifiedString = s.Remove(j, 1);
        var reverse = new string(modifiedString.Reverse().ToArray());
        Console.WriteLine($"j: {j}\nchar at j: {s[j]}\n{s}\n{modifiedString}\n{reverse}");
        if (modifiedString.SequenceEqual(modifiedString.Reverse()))
        {
            index = j;
            Console.WriteLine($"Success at Index: {index}\n Palindrome: {modifiedString}");
            break;
        }
    }
    if (index == -1)
    {
        Console.WriteLine($"Failed to Find:\n {s}");
    }

}
/*
quyjjdcgsvvsgcdjjyq
hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh
fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf
bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb
fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf
mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdylqmgfwrpceakceblfhfeibmm
tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt
lhrxvssvxrhl
prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp
kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk

1
8
33
23
24
43
20
-1
14
-1
*/