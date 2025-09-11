// Sort an array of 0s, 1s and 2s using counting sort approach
// Time Complexity: O(n)

using System;

class Program
{
  static void Sort012_Count(int[] nums)
  {
    int count0 = 0, count1 = 0, count2 = 0;

    foreach (int num in nums)
    {
      if (num == 0) count0++;
      else if (num == 1) count1++;
      else if (num == 2) count2++;
    }

    int index = 0;

    for (int i = 0; i < count0; i++)
      nums[index++] = 0;

    for (int i = 0; i < count1; i++)
      nums[index++] = 1;

    for (int i = 0; i < count2; i++)
      nums[index++] = 2;
  }

  static void Main(string[] args)
  {
    int[] nums = { 0, 1, 2, 0, 1, 2, 1, 0 };
    Sort012_Count(nums);
    Console.WriteLine(string.Join(", ", nums));
  }
}
