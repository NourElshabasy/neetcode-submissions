public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int x = 1;
        int numZeros = 0;
        int[] output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                numZeros++;
            } else {
                x = x * nums[i];
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (numZeros > 1) {
                output[i] = 0;
            } else if (numZeros > 0) {
                if (nums[i] == 0)
                    output[i] = x;
                else
                    output[i] = 0;
            } else
                output[i] = x / nums[i];
        }

        return output;
    }
}
