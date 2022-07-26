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

var s = "asdf";
var index = -1;

if (s.SequenceEqual(s.Reverse()))
{
    return index;
}

string modifiedString;

for (var j = 0; j < s.Length; j++)
{
    modifiedString = s.Remove(j, 1);

    if (modifiedString.SequenceEqual(modifiedString.Reverse()))
    {
        index = j;
        return index;
    }
}

return index;

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
 */