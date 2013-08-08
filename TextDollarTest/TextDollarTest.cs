using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TextDollarTest
{
    [TestClass]
    public class TextDollarTest
    {
        [TestMethod]
        public void Test3()
        {
            string result = Program.ConvertNumberToTextDollars("3");
            Assert.AreEqual("ThreeDollars", result);
        }

        [TestMethod]
        public void Test10()
        {
            string result = Program.ConvertNumberToTextDollars("10");
            Assert.AreEqual("TenDollars", result);
        }

        [TestMethod]
        public void Test21()
        {
            string result = Program.ConvertNumberToTextDollars("21");
            Assert.AreEqual("TwentyOneDollars", result);
        }

        [TestMethod]
        public void Test466()
        {
            string result = Program.ConvertNumberToTextDollars("466");
            Assert.AreEqual("FourHundredSixtySixDollars", result);
        }

        [TestMethod]
        public void Test1234()
        {
            string result = Program.ConvertNumberToTextDollars("1234");
            Assert.AreEqual("OneThousandTwoHundredThirtyFourDollars", result);
        }

        [TestMethod]
        public void Test12000()
        {
            string result = Program.ConvertNumberToTextDollars("12000");
            Assert.AreEqual("TwelveThousandDollars", result);
        }

        [TestMethod]
        public void Test654321()
        {
            string result = Program.ConvertNumberToTextDollars("654321");
            Assert.AreEqual("SixHundredFiftyFourThousandThreeHundredTwentyOneDollars", result);
        }

        [TestMethod]
        public void Test987654321()
        {
            string result = Program.ConvertNumberToTextDollars("987654321");
            Assert.AreEqual("NineHundredEightySevenMillionSixHundredFiftyFourThousandThreeHundredTwentyOneDollars", result);
        }

        [TestMethod]
        public void Test1000321()
        {
            string result = Program.ConvertNumberToTextDollars("1000321");
            Assert.AreEqual("OneMillionThreeHundredTwentyOneDollars", result);
        }
    }
}
