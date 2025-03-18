namespace LeetCode._80;

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Length;
        int prevIndex = 2;
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[prevIndex - 2])
            {
                nums[prevIndex] = nums[i];
                prevIndex++;
            }
        }
        //Console.WriteLine(string.Join(',', nums));
        return prevIndex;
    }
}