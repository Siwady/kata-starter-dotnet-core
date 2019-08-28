using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            var delimitors = new[] {",", "\n"};
            if (string.IsNullOrEmpty(s))
                return 0;
            
            if (s.Contains("//"))
            {
                var text = s.Split("\n");
                delimitors = new[] {text[0].Replace("//", "")};
                s = text[1];
            }

            var numbers = s.Split(delimitors, StringSplitOptions.None).Select(int.Parse);

            return numbers.Sum();
        }
    }
}