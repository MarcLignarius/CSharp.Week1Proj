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
    public void CheckSentence_CheckForOneMatch_Int1()
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
    public void CheckSentence_CheckForMultipleMatches_Int2()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("I love coding I think coding is great!", "coding");
      //Assert
      Assert.AreEqual(2, newRepeatCounter.AddWordMatches());
    }

    [TestMethod]
    public void CheckSentence_IgnorePartials_Int0()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("I guess decoding is cool too.", "coding");
      //Assert
      Assert.AreEqual(0, newRepeatCounter.AddWordMatches());
    }

  }
}
