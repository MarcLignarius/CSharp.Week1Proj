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
    public void CheckSentence_CheckForOneInstance_Int()
    {
      //Arrange
      string userInput = "coding";
      string findWord = "coding";
      Sentence newSentence = new Sentence(userInput, findWord);
      //Act
      int result =newSentence.FindAndCountWord(userInput, findWord);
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void CheckSentence_RegardlessOfCase_Int()
    {
      //Arrange
      string userInput = "Coding";
      string findWord = "coding";
      Sentence newSentence = new Sentence(userInput, findWord);
      //Act
      int result =newSentence.FindAndCountWord(userInput, findWord);
      //Assert
      Assert.AreEqual(1, result);
    }

  }
}
