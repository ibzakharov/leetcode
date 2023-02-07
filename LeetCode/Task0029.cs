namespace LeetCode;

public class Task0029
{
    public int Divide(int dividend, int divisor)
    {
        var result = 0;

        var sign = (dividend < 0 ^ divisor < 0);

        if (dividend == int.MinValue && divisor == -1)
        {
            dividend += 1;
        }

        var dividendAbs = Math.Abs((long)dividend);
        var divisorAbs = Math.Abs((long)divisor);

        while (dividendAbs >= divisorAbs)
        {
            var temp = divisorAbs;
            var oldTemp = temp;
            var count = 1;
            var oldCount = count;

            while (temp < dividendAbs && temp > 0)
            {
                oldTemp = temp;
                temp <<= 1;
                oldCount = count;
                count <<= 1;
            }

            dividendAbs -= oldTemp;
            result += oldCount;
        }

        result = sign ? -result : result;

        return result;
    }
}