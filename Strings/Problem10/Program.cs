// Generate all permutations of a given string

using System;

class Program
{
  static void Permute(string str, string prefix, List<string> result)
  {
    if (str.Length == 0)
    {
      result.Add(prefix);
    }
    else
    {
      for (int i = 0; i < str.Length; i++)
      {
        string rem = str.Substring(0, i) + str.Substring(i + 1);
        Permute(rem, prefix + str[i], result);
      }
    }
  }

  static void Main(string[] args)
  {
    string str = "ABC";
    List<string> result = new List<string>();
    Permute(str, "", result);
    Console.WriteLine("All permutations of the string are:");
    foreach (string s in result)
    {
      Console.WriteLine(s);
    }
  }
}
