namespace Anagram.Models
{
  public class Word
  {
    private string _singleWord;
    //private string[] _myArray;

    public Word (string singleWord)
    {
      _singleWord = singleWord;
      //_myArray = myArray;
    }

    public string CollectWord()
    {
      return _singleWord;
    }

    public void ConvertString()
    {
      // return _myArray;
    }
  }
}
