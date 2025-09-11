// Find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

using System;

class Program
{
  static string FindLongestCommonPrefix(string[] strs)
  {
    if (strs == null || strs.Length == 0) return "";

    string prefix = strs[0];

    for (int i = 1; i < strs.Length; i++)
    {
      while (!strs[i].StartsWith(prefix))
      {
        prefix = prefix.Substring(0, prefix.Length - 1);
        if (string.IsNullOrEmpty(prefix)) return "";
      }
    }

    return prefix;
  }
  
  static void Main(string[] args)
  {
    string[] strs = { "flower", "flow", "flight" };
    string result = FindLongestCommonPrefix(strs);
    Console.WriteLine($"Longest common prefix: {result}");
  }
}
