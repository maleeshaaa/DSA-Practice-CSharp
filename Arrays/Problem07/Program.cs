// Find all pairs in an array that sum to a specific target number

using System;

class Program
{
  static void FindPairs(int[] arr, int target)
  {
    Console.WriteLine($"Pairs that sum to {target}:");

    for (int i = 0; i < arr.Length; i++)
    {
      for (int j = i + 1; j < arr.Length; j++)
      {
        if (arr[i] + arr[j] == target)
        {
          Console.WriteLine($"({arr[i]}, {arr[j]})");
        }
      }
    }
  }
  
  static void Main()
  {
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int target = 10;

    FindPairs(arr, target);
  }
}