using System;

class ScriptureReference
{
   private string _book = "2 Nephi";
   private string _chapterNumber = "31";
   private string _beginVerseNumber =  "21";

   public ScriptureReference(string _startVerse)
   {
        
   }
   public ScriptureReference(string _startVerse, string _endVerse)
   {

   }
   private string _finishVerseNumber;
   public string inputReference()
   {
    if (_beginVerseNumber != null && _finishVerseNumber != null)
    {
        string reference = $"{_book} {_chapterNumber}: {_beginVerseNumber}-{_finishVerseNumber}";
        return reference;
    } else
    {
        string reference = $"{_book} {_chapterNumber}:{_finishVerseNumber}";
        return reference;
    }
   }
}