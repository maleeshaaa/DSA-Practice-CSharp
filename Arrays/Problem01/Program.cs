// Find the second largest element in an array

using System;

class EX01
{
  static void Main()
  {
    int[] arr = { 12, 35, 1, 10, 34, 1 };
    int firstLargest = int.MinValue;
    int secondLargest = int.MinValue;

    foreach (int num in arr)
    {
      if (num > firstLargest)
      {
        secondLargest = firstLargest;
        firstLargest = num;
      }
      else if (num > secondLargest && num != firstLargest)
      {
        secondLargest = num;
      }
    }

    if (secondLargest == int.MinValue)
    {
      Console.WriteLine("There is no second largest element.");
    }
    else
    {
      Console.WriteLine("The second largest element is: " + secondLargest);
    }
  }
}