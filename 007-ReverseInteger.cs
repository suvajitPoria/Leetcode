public class Solution {
    public int Reverse(int x) {
        bool flag = false;
        if(x<0)
        {
            flag = true;
            x = x*-1;
        }

        int reverse = 0;

        while (x > 0)
        {
            int r = x % 10;
            x /= 10;
            if (reverse > int.MaxValue / 10 || 
            (reverse == int.MaxValue / 10 &&     r > 7))
            {
                return 0;
            }
            if (reverse < int.MinValue / 10 || 
           (reverse == int.MinValue / 10 && r < -8))
           {
                return 0;
           }
            reverse = reverse * 10 + r;
        }
        if(flag)
        {
            reverse *= -1;
        }
        return reverse;
    }
}
