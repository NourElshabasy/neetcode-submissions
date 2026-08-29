public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach (string s in tokens) {
            if (s == "+") {
                stack.Push(stack.Pop() + stack.Pop());
            } else if (s == "-") {
                int num = stack.Pop();
                stack.Push(stack.Pop() - num);
            } else if (s == "*") {
                stack.Push(stack.Pop() * stack.Pop());
            } else if (s == "/") {
                int num = stack.Pop();
                stack.Push(stack.Pop() / num);
            } else {
                stack.Push(int.Parse(s));
            }
        }

        return stack.Peek();
    }
}
