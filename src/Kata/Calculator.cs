using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s="")
        {
            var delimiters = new[]{",","\n"};
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Contains("//"))
            {
                var textsplitted = s.Split("\n");
                var delimiter = textsplitted[0]
                    .Replace("/", "")
                    .Replace("[", "")
                    .Replace("]", "");
                delimiters = new[] {delimiter};
                s = textsplitted[1];
            }

            var numbers = s.Split(delimiters, StringSplitOptions.None).Select(int.Parse).Where(x=>x<1001);

            var negatives = numbers.Where(x => x < 0);
            if (negatives.Any())
            {
                throw new Exception($"negatives not allowed: {string.Join(", ", negatives)}");
            }
            if (numbers.Count() == 1)
                return numbers.First();

            return numbers.Sum();
        }
    }
}