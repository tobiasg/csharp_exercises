using System;
using System.Diagnostics;

// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace FindMedianSortedArrays {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine(FindMedianSortedArrays([1, 3], [2]));
            //Console.WriteLine(FindMedianSortedArrays([1, 2], [3,4]));

            Debug.Assert(FindMedianSortedArrays([1, 3], [2]) == 2.0);
            Debug.Assert(FindMedianSortedArrays([1, 2], [3, 4]) == 2.5);

            Console.WriteLine("Passed");
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int[] merged = nums1.Concat(nums2).ToArray();
            Array.Sort(merged);

            int indexOfMiddleValue = merged.Length / 2;

            if (merged.Length % 2 == 0) {
                return (merged[indexOfMiddleValue - 1] + merged[indexOfMiddleValue]) / 2.0;
            } else {
                return merged[indexOfMiddleValue];
            }
        }
    }
}