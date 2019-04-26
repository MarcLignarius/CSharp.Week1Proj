using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {

    public int FindWord(string toCheck, string toCompare)
    {
      if (toCheck == toCompare)
      {
        return 1;
      }
      return 0;
    }
  }
}
