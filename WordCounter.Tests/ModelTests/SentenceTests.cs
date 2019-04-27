using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void CheckSentence_CheckForOneInstance_Int1()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("I love coding", "coding");
      //Assert
      Assert.AreEqual(1, newRepeatCounter.AddWordMatches());
    }

    [TestMethod]
    public void CheckSentence_RegardlessOfCase_Int()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("I love CODING", "coding");
      Assert.AreEqual(1, newRepeatCounter.AddWordMatches());
    }

    [TestMethod]
    public void CheckSentence_CheckForMultipleInstances_Int2()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("I love coding I think coding is great!", "coding");
      //Assert
      Assert.AreEqual(2, newRepeatCounter.AddWordMatches());
    }

  }
}
