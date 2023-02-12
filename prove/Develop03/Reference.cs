using System;

class ScriptureReference
{
   private string _book = "2 Nephi";
   private string _chapterNumber = "31";
   private string _verseNumber =  "21";

   public ScriptureReference(string _verseNumber)
   {

   }
   public string inputReference()
   {
    if (_verseNumber != null)
    {
        string reference = $"{_book} {_chapterNumber}:{_verseNumber}";
        return reference;
    } else
    {
        string reference = $"{_book} {_chapterNumber}:{_verseNumber}";
        return reference;
    }
   }
}