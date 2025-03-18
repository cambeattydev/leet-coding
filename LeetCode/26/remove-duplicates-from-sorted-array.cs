namespace LeetCode._26;

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        var index = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        
        return index;
    }
}