using System.Collections.Generic;

namespace Scrabble.Models

{
  public class ScrabbleScore
  {
    public string Word { get; set; }
    public ScrabbleScore(string word)
    {
      Word = word.ToLower();
    }

    public int GetPoints()
    {
      char[] wordArray = Word.ToCharArray();
      int points = 0;
      
      for (int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == 'a' || wordArray[i] == 'e' || wordArray[i] == 'i' || wordArray[i] == 'o' || wordArray[i] == 'u' || wordArray[i] == 'l' || wordArray[i] == 'n' || wordArray[i] == 'r' || wordArray[i] == 's' || wordArray[i] == 't')
        {
          points += 1;

        } else if (wordArray[i] == 'd' || wordArray[i] == 'g')
        {
          points += 2;

        } else if (wordArray[i] == 'b' || wordArray[i] == 'c' || wordArray[i] == 'm' || wordArray[i] == 'p')  
        {
          points += 3;

        } else if (wordArray[i] == 'f' || wordArray[i] == 'h' || wordArray[i] == 'v' || wordArray[i] == 'w' || wordArray[i] == 'y') 
        {
          points += 4;

        } else if (wordArray[i] == 'k')
        {
          points += 5;

        } else if (wordArray[i] == 'j' || wordArray[i] == 'x') 
        {
          points += 8;

        } else if (wordArray[i] == 'q' || wordArray[i] == 'z')
        {
          points += 10;

        } else {
          return points = 0;
        }
      }
      return points;
    }
  }
}