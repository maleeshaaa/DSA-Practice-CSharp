// Find the intersection of two arrays, returning a new array with unique elements only and another with duplicates allowed.
// For example, given arrays [1, 2, 2, 3] and [2, 2, 3, 4], the unique intersection is [2, 3] and the intersection with duplicates is [2, 2, 3].

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
  static int[] IntersectionWithoutDuplicates(int[] array1, int[] array2)
  {
    HashSet<int> set1 = new HashSet<int>(array1);
    HashSet<int> set2 = new HashSet<int>(array2);
    set1.IntersectWith(set2);
    return set1.ToArray();
  }

  static int[] IntersectionWithoutDuplicates_Manual(int[] array1, int[] array2)
  {
    HashSet<int> set1 = new HashSet<int>(array1);
    HashSet<int> resultSet = new HashSet<int>();

    foreach (int num in array2)
    {
      if (set1.Contains(num))
      {
        resultSet.Add(num);
      }
    }

    return resultSet.ToArray();
  }

  static int[] IntersectionWithDuplicates(int[] array1, int[] array2)
  {
    Array.Sort(array1);
    Array.Sort(array2);

    List<int> result = new List<int>();

    int i = 0, j = 0;
    
    while (i < array1.Length && j < array2.Length)
    {
      if (array1[i] < array2[j])
      {
        i++;
      }
      else if (array1[i] > array2[j])
      {
        j++;
      }
      else
      {
        result.Add(array1[i]);
        i++;
        j++;
      }
    }
    return result.ToArray();
  }

  static void Main(string[] args)
  {
    int[] array1 = { 1, 2, 2, 3, 4, 4 };
    int[] array2 = { 3, 4, 4, 5, 6 };

    int[] result = IntersectionWithoutDuplicates(array1, array2);
    Console.WriteLine("Intersection without duplicates: " + string.Join(", ", result));

    int[] resultManual = IntersectionWithoutDuplicates_Manual(array1, array2);
    Console.WriteLine("Intersection without duplicates (Manual): " + string.Join(", ", resultManual));

    int[] resultWithDuplicates = IntersectionWithDuplicates(array1, array2);
    Console.WriteLine("Intersection with duplicates: " + string.Join(", ", resultWithDuplicates));
  }
}
