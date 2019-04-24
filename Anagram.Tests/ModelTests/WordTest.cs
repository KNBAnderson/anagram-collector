using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace Anagram.Test
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void SortingTheWord_true()
    {
      Anagram newAnagram = new Anagram();
      Assert.AreEqual("abot", newAnagram.SortWord("boat"));
    }

    [TestMethod]
    public void CheckList_true()
    {
      Anagram newAnagram = new Anagram();
      string userWord = "boat";
      Assert.AreEqual("abot toba ", newAnagram.CheckList(userWord, "abot okay blah idk toba"));
    }

  }
}
