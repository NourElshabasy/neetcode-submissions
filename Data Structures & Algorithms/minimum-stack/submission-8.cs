public class MinStack {
    private List<int> stack;
    private List<int> minList;

    public MinStack() {
        stack = new List<int>();
        minList = new List<int>();
    }
    
    public void Push(int val) {
        stack.Add(val);
        if (minList.Count == 0)
        {
            minList.Add(val);
        }
        else 
        {
            minList.Add(Math.Min(val, minList[minList.Count - 1]));
        }
        
    }
    
    public void Pop() {

        stack.RemoveAt(stack.Count - 1);
        minList.RemoveAt(minList.Count - 1);
        
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return minList[minList.Count - 1];
    }
}
