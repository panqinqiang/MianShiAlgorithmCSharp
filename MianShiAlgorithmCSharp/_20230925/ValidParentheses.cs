namespace MianShiAlgorithmCSharp._20230925;

public class ValidParentheses
{
    public static bool IsVaild(string s)
    {
        Stack<char> stack = new Stack<char>();
        string openBrackets = "({[";
        string closeBrackets = ")}]";

        foreach (char c in s)
        {
            if (openBrackets.Contains(c))
            {
                stack.Push(c);
            }else if (closeBrackets.Contains(c))
            {
                if (stack.Count == 0 || stack.Pop() != GetMatchingOpenBracket(c))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
    
    private static char GetMatchingOpenBracket(char closeBracket) {
        switch (closeBracket) {
            case ')':
                return '(';
            case '}':
                return '{';
            case ']':
                return '[';
            default:
                return ' ';
        }
    }
}