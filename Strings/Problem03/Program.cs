// Reverse words in a sentence

using System;

class Program
{
  static string ReverseSentence(string sentence)
  {
    string[] words = sentence.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
  }

  static void Main(string[] args)
  {
    Console.Write("Enter a sentence: ");
    string input = Console.ReadLine();
    string reversedStr = ReverseSentence(input);
    Console.WriteLine("Reversed sentence: " + reversedStr);
  }
}