using System.Text;

namespace Codewars;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        if(string.IsNullOrWhiteSpace(phrase)) return phrase;

        var b = new StringBuilder(phrase.Length);
        b.Append(char.ToUpper(phrase[0]));

        for(int i = 1, length = phrase.Length; i < length; i++)
        {
            var c = phrase[i];
            if(phrase[i - 1] == ' ')
            {
                b.Append(char.ToUpper(c));
            }
            else
            {
                b.Append(c);
            }
        }        

        return b.ToString();
    }
}
