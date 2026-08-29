public class MinStack {
    private List<int> stack;
    private List<int> minList;
    public int min;

    public MinStack() {
        stack = new List<int>();
        minList = new List<int>();
        min = int.MaxValue;
    }
    
    public void Push(int val) {
        stack.Add(val);
        if (val < min)
        {
            min = val;
        }

        minList.Add(min);
    }
    
    public void Pop() {

        stack.RemoveAt(stack.Count - 1);
        minList.RemoveAt(minList.Count - 1);
        
        if (stack.Count > 0)
        {
            min = minList[minList.Count - 1];
        }
        else
        {
            min = int.MaxValue;
        }
        
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return min;
    }
}
