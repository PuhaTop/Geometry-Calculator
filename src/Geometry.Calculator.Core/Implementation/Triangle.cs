using Geometry.Calculator.Core.Interface;

namespace Geometry.Calculator.Core.Implementation;

public class Triangle : IGeometryCalculator
{
    private readonly double _sideOne;
    private readonly double _sideTwo;
    private readonly double _sideThree;

    public Triangle(double sideOne, double sideTwo, double sideThree) =>
        (_sideOne, _sideTwo, _sideThree) = (sideOne, sideTwo, sideThree);
    
    public double Answer()
    {
        if (_sideOne <= 0 || _sideTwo <= 0 || _sideThree <= 0)
        {
            throw new ArgumentException("Проверьте входные данные");
        }
        var perimeter = (_sideOne + _sideTwo + _sideThree) / 2;
        return Math.Round(Math.Sqrt(perimeter * (perimeter - _sideOne) * (perimeter-_sideTwo) * (perimeter - _sideThree)),2,MidpointRounding.ToZero);
    }
}