using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ringtones.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
     
            [TestMethod]
            public void Index_ReturnsViewResult()
            {
                // Arrange
                HomeController controller = new HomeController();
                // Act
                var result = controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
            }
        }
    }

