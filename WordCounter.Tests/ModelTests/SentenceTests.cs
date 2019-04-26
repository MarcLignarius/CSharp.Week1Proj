using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class SentenceTest
  {

    [TestMethod]
    public int Sentence_CountWordInSentence_int()
    {
      // Arrange
      Sentence newSentence = new Sentence("I love coding, coding is great!", "coding");
      // Act
      int result = newSentence.CountStringOccurrences("I love coding, coding is great!", "coding");
      // Assert
      Assert.AreEqual(0, result);
    }

  }
}
