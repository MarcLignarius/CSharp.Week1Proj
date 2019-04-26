using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Sentence
  {
    private string ToSearch;
    private string ToFind;

    public Sentence(string toSearch, string toFind)
    {
      ToSearch = toSearch;
      ToFind = toFind;
    }

    public int CountStringOccurrences(string toSearch, string toFind)
    {
      {
        int count = 0;
        int i = 0;
        while ((i = toSearch.IndexOf(toFind, i)) != -1)
        {
          i += toFind.Length;
          count++;
        }
        return count;
      }
      return 0;
    }

  }
}
