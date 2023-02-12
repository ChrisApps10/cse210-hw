using System;

class Word
{
   public string separateWords(string scriptureString)
   {
    string st1 = scriptureString;
    List<string> result = st1?.Split(' ').ToList();
    var random = new Random();
    int index = random.Next(result.Count);
    string randomWord = result[index];
    Console.WriteLine(randomWord);
    return randomWord;
    
   }
}