using System.Collections.Generic;

namespace Scrabble.Models

{
  public class ScrabbleScore
  {
    public string Word { get; set; }

    public ScrabbleScore(string word)
    {
      Word = word;
    }
  }
}