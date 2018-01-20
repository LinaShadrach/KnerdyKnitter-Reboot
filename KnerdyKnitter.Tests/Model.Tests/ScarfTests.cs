using System;
using KnerdyKnitter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnerdyKnitter.Tests.Model.Tests
{
    [TestClass]
    public class ScarfTests
    {
        [TestMethod]
        public void GetCell_ReturnsCorrectCell_0()
        {
            Scarf scarf = new Scarf(30, 8, 8);
            int[] triplet = new int[] { 1, 1, 1 };
            int resultCell = scarf.GetCell(triplet);
            Assert.AreEqual(0, resultCell);
        }

    }
}
