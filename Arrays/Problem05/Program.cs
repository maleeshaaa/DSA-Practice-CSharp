// Merge two sorted arrays into one sorted array

using System;

class Program
{
  static void Main()
  {
    int[] arr1 = { 1, 3, 5 };
    int[] arr2 = { 2, 4, 6 };
    int[] mergedArray = new int[arr1.Length + arr2.Length];

    int i = 0, j = 0, k = 0;

    while (i < arr1.Length && j < arr2.Length)
    {
      if (arr1[i] < arr2[j])
      {
        mergedArray[k++] = arr1[i++];
      }
      else
      {
        mergedArray[k++] = arr2[j++];
      }
    }

    while (i < arr1.Length)
    {
      mergedArray[k++] = arr1[i++];
    }

    while (j < arr2.Length)
    {
      mergedArray[k++] = arr2[j++];
    }

    Console.WriteLine(string.Join(" ", mergedArray));
  }
}
