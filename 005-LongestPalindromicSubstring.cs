public class Solution
{
    public string LongestPalindrome(string s)
    {
        char[] temp = null;
        char[] charArray = s.ToCharArray();
        string result = null;
        bool flag = false;
        if(isPalindrome(s))
        {
            return s;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    int p = 0;
                    int k;
                    temp = new char[s.Length-1-i];
                    for (k = j; k < (s.Length - 1 - i + j); k++)
                    { 
                        temp[p] = charArray[k];
                        p++;
                    }
                    if (isPalindrome(new string(temp)))
                    {
                        result = new string(temp);
                        flag = true;
                        break;
                    }
                    temp = null;
                    if (j + s.Length - 1 - i >= s.Length)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            return result;
        }
    }
    public bool isPalindrome(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        string palindromeArray = new string(charArray);
        if (s.Equals(palindromeArray))
        {
            return true;
        }
        return false;
    }
}
