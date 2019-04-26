using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Sentence
  {
    private string _UserInput;
    private string _FindWord;

    public Sentence(string userInput, string findWord)
    {
      _UserInput = userInput;
      _FindWord = findWord;
    }

    public int FindAndCountWord(string userInput, string findWord)
    {
      if (userInput.ToLower() == findWord.ToLower())
      {
        return 1;
      }
      return 0;
    }


  }
}
