public static class Program
{
    public static void Main()
    {
        var s = "aab";
        var val = LengthOfLongestSubstring(s);
        
    }

    public static int LengthOfLongestSubstring(string s) {
        var start = 0;
        var end = 0;
        var hashSet = new System.Collections.Generic.HashSet<char>();
        var maxLength = 0;
        char current;
        while(end < s.Length) {
            current = s[end];
            if (!hashSet.Contains(current)) {
                hashSet.Add(current);
            } else
            {
                maxLength = Math.Max(maxLength, end - start);
                hashSet.Clear();
                var startSymbol = char.MinValue;
                while(startSymbol != current) {
                    end--;
                    startSymbol = s[end];
                }

                start = end + 1;
            }
            end++;
        }
        
        maxLength = Math.Max(maxLength, end - start);

        return maxLength;       
    }

}