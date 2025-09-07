// Check if two strings are anagrams. in strings

using System;

class Program
{
  static bool IsAnagram(string s1, string s2)
  {
    if (s1.Length != s2.Length)
      return false;

    char[] charArray1 = s1.ToCharArray();
    char[] charArray2 = s2.ToCharArray();
    Array.Sort(charArray1);
    Array.Sort(charArray2);

    return new string(charArray1) == new string(charArray2);
  }

  static void Main(string[] args)
  {
    Console.Write("Enter first string: ");
    string str1 = Console.ReadLine();

    Console.Write("Enter second string: ");
    string str2 = Console.ReadLine();

    if (IsAnagram(str1, str2))
      Console.WriteLine($"{str1} and {str2} are anagrams.");
    else
      Console.WriteLine($"{str1} and {str2} are not anagrams.");
  }
}