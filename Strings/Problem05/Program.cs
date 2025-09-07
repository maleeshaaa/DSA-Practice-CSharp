// Count vowels and consonants

using System;

class Program
{
  static void CountVowelsAndConsonants(string input, out int vowelCount, out int consonantsCount)
  {
    vowelCount = 0;
    consonantsCount = 0;
    string vowels = "aeiouAEIOU";

    foreach (char c in input)
    {
      if (char.IsLetter(c))
      {
        if (vowels.Contains(c))
        {
          vowelCount++;
        }
        else
        {
          consonantsCount++;
        }
      }
    }
  }

  static void Main()
  {
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    CountVowelsAndConsonants(input, out int vowels, out int consonants);

    Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
  }
}
