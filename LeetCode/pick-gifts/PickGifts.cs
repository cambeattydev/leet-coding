//https://leetcode.com/problems/take-gifts-from-the-richest-pile
namespace LeetCode.pick_gifts;

public class Solution {
    public long PickGifts(int[] gifts, int k)
    {
        var sortedGifts = gifts.OrderBy(g => g).ToList();
        for (var i = 0; i < k; i++)
        {
            var maxItem = sortedGifts.ElementAt(sortedGifts.Count - 1);
            sortedGifts.RemoveAt(sortedGifts.Count - 1);
            var newVal = (int) Math.Floor(Math.Sqrt(maxItem));
            var newIndex = sortedGifts.BinarySearch(newVal);
            if (newIndex < 0)
            {
                newIndex = ~newIndex;
            }
            sortedGifts.Insert(newIndex, newVal);
        }
        return sortedGifts.Sum(val => (long)val);
    }
}