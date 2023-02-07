using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task0029Test
{
    [TestMethod]
    public void Divide()
    {
        var task = new Task0029();
        var actual = task.Divide(10, 3);
    
        Assert.AreEqual(3, actual);
    }
    
    [TestMethod]
    public void Divide_NegativeDividend()
    {
        var task = new Task0029();
        var actual = task.Divide(-10, 3);
    
        Assert.AreEqual(-3, actual);
    }
    
    [TestMethod]
    public void Divide_NegativeDivisor()
    {
        var task = new Task0029();
        var actual = task.Divide(10, -3);
    
        Assert.AreEqual(-3, actual);
    }
    
    [TestMethod]
    public void Divide_DividendAnDivisorAreEqual()
    {
        var task = new Task0029();
        var actual = task.Divide(1, 1);
    
        Assert.AreEqual(1, actual);
    }
    
    [TestMethod]
    public void Divide_1()
    {
        var task = new Task0029();
        var actual = task.Divide(-2147483648, -1);
    
        Assert.AreEqual(2147483647, actual);
    }
    
    [TestMethod]
    public void Divide_2()
    {
        var task = new Task0029();
        var actual = task.Divide(-2147483648, 1);
    
        Assert.AreEqual(-2147483648, actual);
    }
}