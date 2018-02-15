using System;
using KnerdyKnitter.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnerdyKnitter.Tests.Controller.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_ReturnsCorrectType_True()
        {
            ViewResult result = new HomeController().Index() as ViewResult;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
