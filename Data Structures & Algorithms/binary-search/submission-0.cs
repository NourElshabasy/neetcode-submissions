public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int m = (left + right) / 2;
            if (nums[m] == target)
                return m;
            else if (nums[m] < target)
            {
                left = m + 1;
            }
            else {
                right = m - 1;
            }
        }

        return -1;

    }
}
