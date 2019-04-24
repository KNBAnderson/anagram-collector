using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    public string SortWord(string word)
    {
      char[] wordArray = word.ToCharArray();
      Array.Sort(wordArray);
      string sortedWord = new string(wordArray);
      return sortedWord;
    }

    public string CheckList(string userWord, string list) {
      string sortedUserWord = SortWord(userWord);
      string[] listArray = list.Split(" ");
      string finalList = "";
      foreach(string word in listArray)
      {
        string sortedWord = SortWord(word);
        if (sortedWord == sortedUserWord)
        {
          finalList+= word + " ";
        }
      }
      return finalList;
    }
  }
}
