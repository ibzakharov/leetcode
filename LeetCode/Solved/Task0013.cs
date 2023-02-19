namespace LeetCode.Solved;

public class Task0013
{
    const char c = 'C';
    const char m = 'M';
    const char d = 'D';
    const char x = 'X';
    const char l = 'L';
    const char i = 'I';
    const char v = 'V';
    
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int RomanToInt(string s)
    {
        var result = 0;

        var prevChar = '0';

        foreach (var currentChar in s)
        {
            switch (currentChar)
            {
                case m:
                    result += prevChar == c ? 800 : 1000;
                    break;
                case d:
                    result += prevChar == c ? 300 : 500;
                    break;
                case c:
                    result += prevChar == x ? 80 : 100;
                    break;
                case l:
                    result += prevChar == x ? 30 : 50;
                    break;
                case x:
                    result += prevChar == i ? 8 : 10;
                    break;
                case v:
                    result += prevChar == i ? 3 : 5;
                    break;
                case i:
                    result += 1;
                    break;
            }

            prevChar = currentChar;
        }

        return result;
    }
}