using System;

class Scripture
{
   private string _scriptureVerse;

   private string _scriptureReference;
   private string _randomWord;

   public Scripture()
   {
      _scriptureVerse = "And now, behold, my beloved brethren, this is the way; and there " +
    "is none other way nor name given under heaven whereby man can be saved in the " + 
    " kingdom of God. And now, behold, this is the doctrine of Christ, and the only " + 
    "  and true doctrine of the Father, and of the Son, and of the Holy Ghost, which is " +
    "one God without end. Amen.";
      _scriptureReference = getReference();
      Word newWord = new Word();
      _randomWord = newWord.separateWords(_scriptureVerse);
   }

   public string getReference()
   {
      ScriptureReference scriptureReference = new ScriptureReference("29");
      _scriptureReference = scriptureReference.inputReference();
      return _scriptureReference;
      
   }

   public string removeWord()
   {
      string st1 = _scriptureVerse;
      List<string> scriptureList = st1?.Split(' ').ToList();
      for(int i=0;i<scriptureList.Count;i++)
      {
         if(scriptureList[i] == _randomWord)
            scriptureList[i] = "_";
      }
      string st2 = string.Join(" ", scriptureList.ToArray());
      _scriptureVerse = st2;
      Word newWord = new Word();
      _randomWord = newWord.separateWords(_scriptureVerse);
      return _scriptureVerse;

   }

   public void Display()
   {
      Console.WriteLine($"{_scriptureReference} - {_scriptureVerse}");
   }
}