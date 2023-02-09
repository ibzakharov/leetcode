using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeUnitTests;

[TestClass]
public class Task0152Test
{
    [TestMethod]
    public void MaxProduct()
    {
        var task = new Task0152();
        var actual = task.MaxProduct(new []{2,3,-2,4});

        Assert.AreEqual(6, actual);
    }
}