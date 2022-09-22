using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

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
  }
}