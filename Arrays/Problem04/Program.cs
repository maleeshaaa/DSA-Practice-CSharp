// Move all zeros to the end without using extra space

using System;

class Program
{
  static void Main()
  {
    int[] arr = { 0, 1, 2, 0, 3, 4 };
    int index = 0;

    foreach (int num in arr)
    {
      if (num != 0)
      {
        arr[index++] = num;
      }
    }

    while (index < arr.Length)
    {
      arr[index++] = 0;
    }

    Console.WriteLine(string.Join(" ", arr));
  }
}