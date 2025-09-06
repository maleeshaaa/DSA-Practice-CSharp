// Find the missing number in a sequence 1…n

using System;

class Program
{
  static void Main()
  {
    int[] arr = [2, 3, 1, 5];
    int n = arr.Length + 1;
    int total = n * (n + 1) / 2;
    int sum = 0;

    foreach (int num in arr)
      sum += num;

    int missingNumber = total - sum;
    Console.WriteLine("Missing Number: " + missingNumber);
  }
}
