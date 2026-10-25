public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = 0;

        for (int i = 0; i < piles.Length; i++)
        {
            if (piles[i] > max)
                max = piles[i];
        } // pilex.Max() // lingq

        int l = 1;
        int r = max;
        int result = max;
        
        while (l <= r)
        {
            int k = l + (r - l) / 2;
            long hours = 0;

            for (int i = 0; i < piles.Length; i++)
            {
                hours += (piles[i] + k - 1) / k;
            }

            if (hours <= h)
            {
                result = k;
                r = k - 1;
            }
            else
            {
                l = k + 1;
            }  
        }

        return result;

    }
}
