using System.Collections.Generic;

namespace Palendrome
{
    public class PalendromeCalculator
    {
        List<PalendromeResult> palindromeResults = new List<PalendromeResult>();

        private static PalendromeCalculator _instance;

        private PalendromeCalculator() { }

        public static PalendromeCalculator Instance()
        {
            return _instance == null 
                ? _instance = new PalendromeCalculator()
                : _instance;
        }

        public bool IsPalindrome(string value)
        {
            if (value.Length <= 1)
                return false;

            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public List<PalendromeResult> GetResults(string input)
        {
            var curr = string.Empty;
            var array = input.ToCharArray();

            for (int ix = 0; ix < array.Length; ix++)
            {
                for (int iy = ix + 1; iy < array.Length; iy++)
                {
                    curr = input.Substring(ix, iy - ix + 1);

                    if (IsPalindrome(curr))
                    {
                        palindromeResults.Add(new PalendromeResult()
                        {
                            Text = curr,
                            Index = ix,
                            Length = curr.Length
                        });
                    }
                }
            }

            return palindromeResults;
        }

    }

    
    public class PalendromeResult
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return string.Format("Text: {0} Index: {1} Length: {2}", Text, Index, Length);
        }
    }
}
