var message = "This-is-a-MESSAGE-z".ToCharArray();
var shift = 13 % 26;

var lowerCase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
var upperCase = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();


for (var i = 0; i < message.Length; i++)
{
    var matchIndex = -1;
    var letter = message[i];
    for (var j = 0; j < lowerCase.Length; j++)
    {
        if (letter == lowerCase[j])
        {
            matchIndex = j + shift;
            if (matchIndex > 25) {
                matchIndex -= 26;
            }
            message[i] = lowerCase[matchIndex];
            break;
        }
        if (letter == upperCase[j])
        {
            matchIndex = j + shift;
            if (matchIndex > 25)
            {
                matchIndex -= 26;
            }
            message[i] = upperCase[matchIndex];
            break;
        }
    }
}
var newMessage = new string(message);
