namespace LeetCode.Solved;

public class Task0012
{
    const string m = "M";
    const string cm = "CM";
    const string d = "D";
    const string cd = "CD";
    const string c = "C";
    const string xc = "XC";
    const string l = "L";
    const string xl = "XL";
    const string x = "X";
    const string ix = "IX";
    const string v = "V";
    const string iv = "IV";
    const string i = "I";

    /// <summary>
    /// https://leetcode.com/problems/integer-to-roman/
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string IntToRoman(int num)
    {
        var list = new List<(int, string)>();
        list.Add((1000, m));
        list.Add((900, cm));
        list.Add((500, d));
        list.Add((400, cd));
        list.Add((100, c));
        list.Add((90, xc));
        list.Add((50, l));
        list.Add((40, xl));
        list.Add((10, x));
        list.Add((9, ix));
        list.Add((5, v));
        list.Add((4, iv));
        list.Add((1, i));

        string result = string.Empty;

        foreach (var (div, symbol) in list)
        {
            while (num / div >= 1 && num / div < 4)
            {
                result += symbol;
                num -= 1 * div;
            }
        }

        return result;
    }
}