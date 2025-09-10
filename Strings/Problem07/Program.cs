// String Compression
// Compresses a string by replacing consecutive identical characters with the character followed by the count of repetitions.
// For example, the string "aaabbcdddde" should be compressed to "a3b2c1d4e1".

using System;

class Program
{
  static string CompressString(string str)
  {
    if (string.IsNullOrEmpty(str)) return "";

    string result = "";
    int count = 1;

    for (int i = 0; i < str.Length; i++)
    {
      if (i + 1 < str.Length && str[i] == str[i + 1])
      {
        count++;
      }
      else
      {
        result += str[i].ToString() + count.ToString();
        count = 1;
      }
    }
    return result;
  }

  static void Main(string[] args)
  {
    string input = "aaabbcdddde";
    string compressed = CompressString(input);

    Console.WriteLine("Original String: " + input);
    Console.WriteLine("Compressed String: " + compressed);
  }
}
