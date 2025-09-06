// Rotate an array k steps to the right

using System;

class Program {
  static void Rotate(int[] nums, int k) {
    k = k % nums.Length;
    Array.Reverse(nums);
    Array.Reverse(nums, 0, k);
    Array.Reverse(nums, k, nums.Length - k);
  }

  static void Main() {
    int[] arr = { 1, 2, 3, 4, 5, 6, 7};
    int k = 3;
    Rotate(arr, k);
    Console.WriteLine(string.Join(" ", arr));
  }
}
