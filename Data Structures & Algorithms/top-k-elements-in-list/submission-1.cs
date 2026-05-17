public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new();
        
        foreach (var num in nums) {
            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        PriorityQueue<int, int> heap = new();
        foreach (var pair in count) {
            heap.Enqueue(pair.Key, pair.Value);
            if (heap.Count > k) {
                heap.Dequeue();
            }
        }

        int[] result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
