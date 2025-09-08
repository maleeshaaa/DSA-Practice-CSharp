// Find the longest substring without repeating characters

using System;

class Program
{
  static string LongestUniqueSubstring(string str)
  {
    string current = "";
    string longest = "";

    foreach (char c in str)
    {
      if (current.Contains(c))
      {
        int index = current.IndexOf(c);
        current = current.Substring(index + 1);
      }

      current += c;

      if (current.Length > longest.Length)
      {
        longest = current;
      }
    }

    return longest;
  }

  static void Main()
  {
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    string result = LongestUniqueSubstring(input);
    Console.WriteLine($"Longest substring without repeating characters: {result}");
    Console.WriteLine($"Length: {result.Length}");
  }
}