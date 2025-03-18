namespace LeetCode._27;

public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var nonVal = 0;
        var lastFlip = nums.Length - 1;
        for (int i = nums.Length -1; i >= 0 ; i--)
        {
            if (nums[i] == val)
            {
                (nums[lastFlip], nums[i]) = (nums[i], nums[lastFlip]);
                lastFlip--;
            }
            else
                nonVal++;
        }

        return nonVal;
    }
}