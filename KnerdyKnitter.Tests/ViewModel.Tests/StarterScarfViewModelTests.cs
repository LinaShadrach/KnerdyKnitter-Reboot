using System;
using KnerdyKnitter.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnerdyKnitter.Tests.ViewModel.Tests
{
	[TestClass]
    public class StarterScarfViewModelTests
    {
        [TestMethod]
        public void GetCellIds_CreateCellId_True()
        {
            StarterScarfViewModel scarf = new StarterScarfViewModel();
            string result = scarf.GetCellIds(0,0);
            Assert.AreEqual(result, "cell00");
        }
    }
}
