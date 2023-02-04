namespace LeetCode;

public class Task1630
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var res = new List<bool>();
        for (int i = 0; i < l.Length; i++)
        {
            bool check = IsCheck(nums, l[i], r[i]);
            res.Add(check);
        }

        return res;
    }

    public bool IsCheck(int[] nums, int start, int end)
    {
        var res = true;
        var sortNums = new int[end - start + 1];
        for (int i = start; i <= end; i++)
        {
            sortNums[i] = nums[i];
        }
        sortNums = sortNums.OrderBy(i => i).ToArray();

        var value = sortNums[1] - sortNums[0];
        for (int i = 2; i < sortNums.Length; i++)
        {
            var diff = sortNums[i] - sortNums[i - 1];
            if (value != diff)
            {
                res = false;
                break;
            }
        }

        return res;
    }
}