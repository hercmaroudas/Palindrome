using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Palendrome.Test
{
    [TestClass]
    public class PalendromCalcuulatorTests
    {
        PalendromeCalculator palendrome;

        [TestInitialize]
        public void Initialize()
        {
            palendrome = PalendromeCalculator.Instance();
        }

        [TestMethod]
        public void Test_Empty_Input_Test()
        {
            var input = string.Empty;

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 0);
        }

        [TestMethod]
        public void Test_Impossible_Input_Because_One_Character_Test()
        {
            var input = "a";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 0);

        }

        [TestMethod]
        public void Test_Simple_Is_Palandrome_Test()
        {
            var input = "aa";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 1);
        }

        [TestMethod]
        public void Test_Simple_Not_Palandrome_Test()
        {
            var input = "ab";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 0);
        }

        [TestMethod]
        public void Test_Basic_Odd_Input_Is_Palendrome_Test()
        {
            var input = "aba";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 1);
        }

        [TestMethod]
        public void Test_Basic_Even_Input_Is_Palendrome_Test()
        {
            var input = "abba";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 2);
        }

        [TestMethod]
        public void Test_Racecar_Input_Is_Palendrome_Test()
        {
            var input = "racecar";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 3);
        }

        [TestMethod]
        public void Test_Simple_Between_Even_Input_Is_Palendrome_Test()
        {
            var input = "xabbax";

            var results = palendrome.GetResults(input);
            Assert.IsTrue(results.Count() == 3);
        }

        [TestMethod]
        public void Test_Racecar_Before_Even_Input_Is_Palendrome_Test()
        {
            var input = "abcracecar";

            var results = palendrome.GetResults(input);
            /*
            [0]	"racecar"
		    [1]	"aceca"	
		    [2]	"cec"	
             */
            Assert.IsTrue(results.Count() == 3);
        }

        [TestMethod]
        public void Test_To_The_Point_Input_Is_Palendrome_Test()
        {
            var input = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";

            var results = palendrome.GetResults(input);
          
            Assert.IsTrue(results.Count() == 17);
        }
    }
}
