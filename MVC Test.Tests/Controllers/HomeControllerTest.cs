using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Test;
using MVC_Test.Controllers;

namespace MVC_Test.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeMyController myController = new HomeMyController();

            // Act
            ViewResult result = myController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeMyController myController = new HomeMyController();

            // Act
            ViewResult result = myController.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeMyController myController = new HomeMyController();

            // Act
            ViewResult result = myController.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
