using LeetCode.Solved;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests.Solved;

[TestClass]
public class Task0013Test
{
    [TestMethod]
    [DataRow("MDCLXVI", 1666)]
    [DataRow("IV", 4)]
    [DataRow("IX", 9)]
    [DataRow("XL", 40)]
    [DataRow("XC", 90)]
    [DataRow("CD", 400)]
    [DataRow("CM", 900)]
    public void RomanToInt(string s, int expected)
    {
        var task = new Task0013();
        var actual = task.RomanToInt(s);

        Assert.AreEqual(expected, actual);
    }
}