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
        [TestMethod]
        public void GetCell_ReturnsCorrectCell_1()
        {
            Scarf scarf = new Scarf(30, 8, 8);
            int[] triplet = new int[] { 0, 1, 0 };
            int resultCell = scarf.GetCell(triplet);
            Assert.AreEqual(1, resultCell);
        }
        [TestMethod]
        public void CreateBaseRow_ReturnsCorrectRow_00011110()
        {
			int[] expectedBaseRow = new int[] { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            Scarf scarf = new Scarf(30, expectedBaseRow.Length, 100);
            int[] resultBaseRow = new int[expectedBaseRow.Length];
            for (int columnIndex = 0; columnIndex < expectedBaseRow.Length; columnIndex++)
            {
                resultBaseRow[columnIndex] = scarf.Creation[columnIndex, 0];
            }
            CollectionAssert.AreEqual(expectedBaseRow, resultBaseRow);
        }

    }
}
