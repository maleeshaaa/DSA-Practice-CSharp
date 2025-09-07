// Check if a string is a valid palindrome

using System;

class Program
{
  static bool IsPalindrome(string str)
  {
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    string newStr = new string(chars);
    return str == newStr;
  }

  static void Main(string[] args)
  {
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    if (IsPalindrome(input))
    {
      Console.WriteLine($"\"{input}\" is a palindrome.");
    }
    else
    {
      Console.WriteLine($"\"{input}\" is not a palindrome.");
    }
  }
}
