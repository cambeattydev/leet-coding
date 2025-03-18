using System.Runtime.InteropServices.Marshalling;

namespace LeetCode._88;

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var res =new int[m+n];
        var leftIndex = 0;
        var rightIndex = 0;
        for(var i =0; i < m+n; i++)
        {
            var left= leftIndex < m ? nums1[leftIndex] : int.MaxValue;
            var right = rightIndex < n ? nums2[rightIndex]: int.MaxValue;
            if (left > right)
            {
                res[i] = right;
                rightIndex++;
            }
            else
            {
                res[i] = left;
                leftIndex++;
            }
        }
        Array.Copy(res, nums1,res.Length);
    }
}