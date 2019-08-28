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
                return 0;
            
            if (s.Contains("//"))
            {
                var text = s.Split("\n");
                delimiters = new[] {text[0].Replace("//", "")};
                s = text[1];
            }

            var numbers = s.Split(delimiters, StringSplitOptions.None).Select(int.Parse).Where(x=> x<1001);

            var negatives = numbers.Where(x => x < 0);

            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
            }

            return numbers.Sum();
        }
    }
}