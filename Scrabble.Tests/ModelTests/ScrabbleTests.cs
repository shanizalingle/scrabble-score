using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests 
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceOfScrabble_Scrabble()
    {
      ScrabbleScore newWord = new ScrabbleScore("test");
      Assert.AreEqual(typeof(ScrabbleScore), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "scrabble";
      ScrabbleScore newWord = new ScrabbleScore(word);
      string result = newWord.Word;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_ReturnsWord_String()
    {
      string word = "scrabble";
      ScrabbleScore newWord = new ScrabbleScore(word);
      string updatedWord = "Game";
      newWord.Word = updatedWord;
      string result = newWord.Word;
      Assert.AreEqual(updatedWord, result);
    }

    [TestMethod]
    public void WordToArray_ReturnsPoints_Number()
    {
      ScrabbleScore testScrabbleScore = new ScrabbleScore("amar");
      Assert.AreEqual( 6, testScrabbleScore.GetPoints());
    }
  }
}