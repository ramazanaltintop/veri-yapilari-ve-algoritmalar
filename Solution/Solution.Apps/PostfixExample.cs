namespace Solution.Apps
{
    public class PostfixExample
    {
        private string expression;
        DataStructures.Stack.LinkedListStack<string> S = 
            new DataStructures.Stack.LinkedListStack<string>();
        
        private string Expression()
        {
            int val1, val2, ans;
            for (int i = 0; i < expression.Length; i++)
            {
                String c = expression.Substring(i, 1);
                if (c.Equals("*"))
                {
                    val1 = int.Parse(S.Pop());
                    val2 = int.Parse(S.Pop());
                    ans = val2 * val1;
                    S.Push(ans.ToString());
                }
                else if (c.Equals("/"))
                {
                    val1 = int.Parse(S.Pop());
                    val2 = int.Parse(S.Pop());
                    ans = val2 / val1;
                    S.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    val1 = int.Parse(S.Pop());
                    val2 = int.Parse(S.Pop());
                    ans = val2 + val1;
                    S.Push(ans.ToString());
                }
                else if (c.Equals("-"))
                {
                    val1 = int.Parse(S.Pop());
                    val2 = int.Parse(S.Pop());
                    ans = val2 - val1;
                    S.Push(ans.ToString());
                }
                else
                {
                    S.Push(c);
                }
            }
            return S.Pop();
        }

        public static string Run(string expression)
        {
            PostfixExample example = new PostfixExample();
            example.expression = expression;
            return example.Expression();
        }
    }
}
