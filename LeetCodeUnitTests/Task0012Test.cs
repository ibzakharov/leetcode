using System.Data;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task0012Test
{
    [TestMethod]
    [DataRow(1666, "MDCLXVI")]
    [DataRow(3666, "MMMDCLXVI")]
    [DataRow(900, "CM")]
    [DataRow(400, "CD")]
    [DataRow(90, "XC")]
    [DataRow(40, "XL")]
    [DataRow(9, "IX")]
    [DataRow(4, "IV")]
    public void RomanToInt(int num, string expected)
    {
        var task = new Task0012();
        var actual = task.IntToRoman(num);

        Assert.AreEqual(expected, actual);
    }
}