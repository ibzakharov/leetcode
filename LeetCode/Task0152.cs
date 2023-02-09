namespace LeetCode;

public class Task0152
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-subarray/description/
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxProduct(int[] nums)
    {
        var end = 0;
        var maxSum = 0;
        var sum = 0;
        
        while (end < nums.Length)
        {
            sum *= nums[end];

            sum = Math.Max(sum, maxSum);

            if (sum <= 0)
            {
                sum = 0;
            }

            end++;
        }

        return maxSum;
    }
}