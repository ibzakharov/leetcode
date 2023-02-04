using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task1630Test
{
    [TestMethod]
    public void CheckArithmeticSubarrays()
    {
        var task = new Task1630();
        var actual = task
            .CheckArithmeticSubarrays(new[] { 4, 6, 5, 9, 3, 7 }, new[] { 0, 0, 2 }, new[] { 2, 3, 5 });

        var expected = new[] { true, false, true };

        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
        Assert.AreEqual(expected[2], actual[2]);
    }

    [TestMethod]
    public void CheckArithmeticSubarrays_01()
    {
        var task = new Task1630();
        var actual = task.CheckArithmeticSubarrays(
            new[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 },
            new[] { 0, 1, 6, 4, 8, 7 },
            new[] { 4, 4, 9, 7, 9, 10 }
        );

        var expected = new[] { false,true,false,false,true,true };

        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
        Assert.AreEqual(expected[2], actual[2]);
        Assert.AreEqual(expected[3], actual[3]);
        Assert.AreEqual(expected[4], actual[4]);
    }
}