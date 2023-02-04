namespace LeetCode;

public class Task0643
{
    public double FindMaxAverage(int[] nums, int k) {
        var start = 0;
        var end = 0;
        double sum = 0;
        double avg = 0;
        while(end < nums.Length) {
            sum += nums[end];
            if (end - start + 1 == k) {
                double subAvg = sum / k;
                if (avg == 0)
                    avg = subAvg;
                avg = Math.Max(subAvg, avg);
                sum -= nums[start];
                start++;
            }

            end++;    
        }

        return avg;
    }
}