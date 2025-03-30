using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars;

public class DetectPangram
{
    public static bool IsPangram(string str)
    {
        var count = 0;
        Span<bool> seen = stackalloc bool[26];

        for(int i = 0, length = str.Length; i < length; i++)
        {
            var c = char.ToLower(str[i]);
            if(c >= 'a' && c <= 'z')
            {
                var asInt = c - 'a';
                if(seen[asInt] == false)
                {
                    count++;
                    seen[asInt] = true;

                    if(count == 26) return true;
                }
            }
        }

        return false;
    }
}
