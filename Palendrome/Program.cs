using System;
using System.Linq;

namespace Palendrome
{
    public class Program
    {
        private static PalendromeCalculator Calculator { get { return PalendromeCalculator.Instance(); } }
    
        public static void Main(string[] args)
        {
            var input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpopsqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

            var palendromeResults = Calculator.GetResults(input)
                .OrderByDescending(o => o.Length);
                            
            var grouped = palendromeResults
                .GroupBy(p => p.Text)
                .Select(g => g.First())
                .Take(3).ToList();

            grouped.ForEach(
                p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
