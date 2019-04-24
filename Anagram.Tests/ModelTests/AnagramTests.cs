using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Linq;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void CollectWord_ReturnWord_String()
    {
      string singleWord = "Hola";
      Word newWord = new Word(singleWord);
      string result = newWord.CollectWord();
      Assert.AreEqual(singleWord, result);
    }

    // [TestMethod]
    // public void SortArray_SortArray_Array()
    // {
    //   string singleWord = "Hola";
    //   Word newWord = new Word(singleWord);
    //   string result = Array.Sort(newWord).SortArray();
    //   Assert.AreEqual(singleWord, result);
    // }

    [TestMethod]
    public void ConvertString_ConvertToArray_Array()
    {
      string inputWord = "Goodbye";
      char[] myArray = inputWord.ToArray();
      char[] result = myArray;
      Assert.AreEqual(myArray, result);
    }
  }
}
