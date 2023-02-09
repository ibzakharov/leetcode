using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task0338Test
{
    [TestMethod]
    public void CountBit()
    {
        var task = new Task0338();
        var actual = task.CountBits(2);
        
        Assert.AreEqual(0, actual[0]);
        Assert.AreEqual(1, actual[1]);
        Assert.AreEqual(1, actual[2]);
    }
}