
using Geometry.Calculator.Core.Implementation;

var circle = new Circle(radius: 4 );

var triangle = new Triangle(sideOne: 5 , sideTwo: 5 , sideThree: 4);

Console.WriteLine($"Площадь круга: {circle.Answer()} ");


var resultTriangle = triangle.Answer();

Console.WriteLine(resultTriangle is double.NaN
    ? "Такого треугольника нет"
    : $"Площадь треугольника : {resultTriangle}");