namespace LeetCode;

/// <summary>
/// https://leetcode.com/problems/counting-bits/
/// </summary>
public class Task0338
{
    public int[] CountBits(int n)
    {
        var list = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            var count = CountBitsInNumber(i);
            list.Add(count);
        }

        return list.ToArray();
    }

    public int CountBitsInNumber(int number)
    {
        var count = 0;

        while (number != 0)
        {
            var bit = number & 1;
            if (bit == 1)
                count++;
            number = number >> 1;
        }

        return count;
    }
}