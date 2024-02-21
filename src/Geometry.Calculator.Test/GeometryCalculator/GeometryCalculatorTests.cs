using Geometry.Calculator.Core.Implementation;

namespace Geometry.Calculator.Test.GeometryCalculator;

[TestFixture]
public class GeometryCalculatorTests
{
    [Test]
    public void CircleValidResult()
    {
        // Arrange 
        var circle = new Circle(radius:4);
        // Act 
        var result = circle.Answer();
        // Assert
        Assert.That(result, Is.EqualTo(50.26));
    }

    [Test]
    public void CircleDataChecking()
    {
        // Arrange 
        var circle = new Circle(-1.3);
        // Act Assert
        Assert.Throws<ArgumentException>(() => circle.Answer());
    }

    [Test]
    public void TriangleValidResult()
    {
        // Arrange
        var triangle = new Triangle(4,4,5);
        
        // Act

        var result = triangle.Answer();
        
        // Assert
        
        Assert.That(result,Is.EqualTo(7.8));

    }
    
    [Test]
    public void TriangleDataChecking()
    {
        // Arrange 
        var triangle = new Triangle(-1.3,0,0);
        // Act Assert
        Assert.Throws<ArgumentException>(() => triangle.Answer());
    }
    
    
    
    
}