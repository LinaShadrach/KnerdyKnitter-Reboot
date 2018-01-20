using KnerdyKnitter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnerdyKnitter.Tests
{
    [TestClass]
    public class RuleTests
    {
        [TestMethod]
        public void GetRuleAsIntArray_ReturnsCorrectIntArray()
        {
            int[] expectedRuleArray = { 0, 1, 1, 1, 1, 0, 0, 0 };
            int[] resultArray = Rule.ConvertRuleToIntArray(30);
            CollectionAssert.AreEqual(expectedRuleArray, resultArray);
        }
    }
}
