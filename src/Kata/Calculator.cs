using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            var delimiters = new[] {",", "\n"};
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Contains("//"))
            {
                var tmpInput = s.Split("\n");
                delimiters = new[] {tmpInput[0].Replace("/", "")};
                s = tmpInput[1];
            }
            var numbers = s.Split(delimiters,StringSplitOptions.None).Select(int.Parse);
            
            return numbers.Sum();
        }
    }
}