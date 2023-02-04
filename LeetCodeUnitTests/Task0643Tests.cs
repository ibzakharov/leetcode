using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task0643Test
{
    [TestMethod]
    public void FindMaxAverage()
    {
        var task = new Task0643();
        var actual = task.FindMaxAverage(new[] { 1, 12, -5, -6, 50, 3 }, 4);
        
        Assert.AreEqual(12.75, actual);
    }
    
    [TestMethod]
    public void FindMaxAverage_01()
    {
        var task = new Task0643();
        var actual = task.FindMaxAverage(new[] { -1 }, 1);
        
        Assert.AreEqual(-1, actual);
    }
}