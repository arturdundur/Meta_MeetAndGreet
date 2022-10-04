using NUnit.Framework;
using UnityEngine;

public class DirectionTest
{
    [Test]
    public void TestNorth()
    {
        Assert.AreEqual(Directions.North, Vector2.up);
    }
    
    [Test]
    public void TestEast()
    {
        Assert.AreEqual(Directions.East, Vector2.right);
    }
    
    [Test]
    public void TestSouth()
    {
        Assert.AreEqual(Directions.South, Vector2.down);
    }
    
    [Test]
    public void TestWest()
    {
        Assert.AreEqual(Directions.West, Vector2.left);
    }
}