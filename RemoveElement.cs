public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        foreach (var item in nums)
        {
            if(item != val)
            {
                nums[count] = item;
                count++;
            }
        }

        return count;
    }
}