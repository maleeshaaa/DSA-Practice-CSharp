// String Rotation Check

using System;

class Program
{
  static bool IsRotationString(string str1, string str2)
  {
    if (str1.Length != str2.Length)
    {
      return false;
    }

    string concatenated = str1 + str1;
    return concatenated.Contains(str2);
  }

  static void Main()
  {
    string str1 = "waterbottle";
    string str2 = "erbottlewat";

    bool result = IsRotationString(str1, str2);
    Console.WriteLine($"Is '{str2}' a rotation of '{str1}'? {result}");
  }
}
