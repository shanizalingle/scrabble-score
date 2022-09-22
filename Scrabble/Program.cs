using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble!");
      
      bool replay = true;
      while(replay)
      {
        Console.WriteLine("Enter P to play or Q to quit");
        string userInput = Console.ReadLine().ToUpper();

        if (userInput == "P")
        {
          Console.WriteLine("Enter a word: ");
          string userWord = Console.ReadLine();
          ScrabbleScore newWord = new ScrabbleScore(userWord);
          Console.WriteLine("Here's your points:");
          Console.WriteLine(newWord.GetPoints());
        }

        else if (userInput == "Q")
        {
          replay = false;
        } 
        
        else 
        {
          Console.WriteLine("This is not a valid command, please try again");
        }
      }
    }
  }
}