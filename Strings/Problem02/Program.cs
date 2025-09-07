// Find the first non-repeating character in a string.

using System;

class Program
{
  static char FirstNonRepeatingChar(string str)
  {
    int[] charCount = new int[256];

    foreach (char c in str)
    {
      charCount[c]++;
    }

    foreach (char c in str)
    {
      if (charCount[c] == 1)
        return c;
    }

    return '\0';
  }

  static void Main()
  {
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    char result = FirstNonRepeatingChar(input);

    if (result != '\0')
      Console.WriteLine($"First non-repeating character: {result}");
    else
      Console.WriteLine("No non-repeating character found.");
  }
}