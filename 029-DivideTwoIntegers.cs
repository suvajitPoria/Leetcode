public class Solution {
    public int Divide(int dividend, int divisor) {
        int i = 0;

        if (dividend == 0)
            return 0;

        if ((dividend == int.MinValue || dividend == int.MaxValue)  && divisor == -1)
        {
            if(dividend == int.MinValue)
            {
                return int.MaxValue;
            }
            else
            {
                return int.MinValue +1;
            }
        }
        if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
        {
            if (dividend > 0)
            { 
                dividend = -dividend;
            }
            if (divisor > 0)
            { 
                divisor = -divisor;
            }
            while (dividend <= divisor)
            {
                dividend -= divisor;
                i++;
            }
        }
        else
        {
            if (dividend > 0)
            { 
                dividend = -dividend;
            }
            if (divisor > 0)
            { 
                divisor = -divisor;
            }
            while (dividend <= divisor)
            {
                dividend -= divisor;
                i--;
            }
        }

        return i;
    }
}
