public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int[]>();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stack.Count > 0 && temperatures[i] > stack.Peek()[0])
            {
                var prev = stack.Pop();
                int prevIndex = prev[1];
                result[prevIndex] = i - prevIndex;
            }
            stack.Push(new int[] { temperatures[i], i });
        }

        return result;
    }
}
