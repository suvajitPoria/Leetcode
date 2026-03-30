public class Solution {
    public bool IsValid(string s) {
        int n = s.Length;
        char[] res = new char[n];
        int k = 0;

        for(int i = 0; i < n; i++)
        {
            char ch = s[i];
            if(ch == '(' || ch == '{' || ch == '[')
            {
                res[k++] = ch;
            }
            else
            {
                if(k == 0) return false;
                if(res[k-1] == GetOpening(ch))
                {
                    k--;
                }
                else
                {
                    return false; 
                }
            }
        }
        return k == 0;
    }

    private char GetOpening(char bracket)
    {
        switch(bracket)
        {
            case ')': return '(';
            case '}': return '{';
            case ']': return '[';
            default: return '0';
        }
    }
}
