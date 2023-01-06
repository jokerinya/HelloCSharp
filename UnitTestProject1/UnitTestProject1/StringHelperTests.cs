using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void AllBlanksShouldBeDeletedFromTheStartAndEndOfTheText()
        {
            // Arrange
            string testText = "  John Doe   ";
            string expected = "John Doe";

            // Act
            string result = StringHelper.EraseExtraBlanks(testText);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AllExtraBlanksInTheGivenTextShouldBeDeleted()
        {
            // Arrange
            string testText = "  John    Doe  Trail   Cops  ";
            string expected = "John Doe Trail Cops";

            // Act
            string result = StringHelper.EraseExtraBlanks(testText);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
