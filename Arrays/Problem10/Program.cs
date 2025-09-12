// Rearrange an array such that positive and negative numbers are placed alternatively.

using System;
using System.Collections.Generic;

class Program
{
  static int[] AlternatePositiveAndNegative(int[] arr)
  {
    List<int> positives = new List<int>();
    List<int> negatives = new List<int>();

    foreach (int num in arr)
    {
      if (num >= 0)
        positives.Add(num);
      else
        negatives.Add(num);
    }

    int n = arr.Length;
    int[] result = new int[n];
    int posIndex = 0, negIndex = 0;
    int i = 0;

    while (posIndex < positives.Count && negIndex < negatives.Count)
    {
      result[i++] = positives[posIndex++];
      result[i++] = negatives[negIndex++];
    }

    while (posIndex < positives.Count)
    {
      result[i++] = positives[posIndex++];
    }

    while (negIndex < negatives.Count)
    {
      result[i++] = negatives[negIndex++];
    }

    return result;
  }

  static void Main()
  {
    int[] array = { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };
    int[] result = AlternatePositiveAndNegative(array);
    Console.WriteLine(string.Join(", ", result));
  }
}
