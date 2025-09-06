// Find the second largest element in an array

using System;

class Program
{
  static void Main()
  {
    int[] arr = { 10, 5, 7 };
    int first = int.MinValue;
    int second = int.MinValue;

    foreach (int num in arr)
    {
      if (num > first)
      {
        second = first;
        first = num;
      }
      else if (num > second && num != first)
      {
        second = num;
      }
    }

    if (second == int.MinValue)
    {
      Console.WriteLine("There is no second largest element");
    }
    else
    {
      Console.WriteLine("The second largest element is " + second);
    }
  }
}