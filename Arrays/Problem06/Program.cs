// Find the maximum sum of a contiguous subarray using Kadane's Algorithm

using System;

class Program
{
  static int MaxSubArraySum(int[] arr)
  {
    int currentSum = arr[0];
    int maxSum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
      currentSum = Math.Max(arr[i], currentSum + arr[i]);
      maxSum = Math.Max(maxSum, currentSum);
    }

    return maxSum;
  }

  static void Main()
  {
    int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
    int maxSum = MaxSubArraySum(arr);
    Console.WriteLine("Maximum contiguous subarray sum is: " + maxSum);
  }
}