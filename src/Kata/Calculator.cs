using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            var delimiters = new[] {",", "\n"};
            if(string.IsNullOrEmpty(s))
                return 0;

            if (s.Contains("//"))
            {
                var tempDelimiters = s.Split("\n");
                delimiters = new[] {tempDelimiters[0].Replace("/", "")};
                s = tempDelimiters[1];
            }

            var numbers = s.Split(delimiters, StringSplitOptions.None).Select(int.Parse);
            return numbers.Sum();
        }
    }
}