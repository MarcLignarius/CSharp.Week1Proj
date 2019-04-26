using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public int FindWord_CountToCompareInToCheck_OneMatch()
    {
      // Arrange
      RepeatCounter newToCheck = new RepeatCounter();
      // Act
      int result = newToCheck.FindWord("I love coding, coding is great!", "code");
      // Assert
      Assert.AreEqual(1, result);
    }

  }
}
