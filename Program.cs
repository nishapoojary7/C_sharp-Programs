// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
abstract class Shape
{
    public abstract double calculateArea();
    public abstract double calculatePerimeter();
}
class Circle:Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius=radius;  
    }
    public override double calculateArea()
    {
        return Math.PI*Math.Pow(radius,2);
    }
    public override double calculatePerimeter()
    {
        return 2* Math.PI*radius;
    }
}
class Triangle:Shape
{
    private double sideA;
     private double sideB;
      private double sideC;
    public Triangle(double sideA,double sideB,double sideC)
    {
        this.sideA=sideA;
        this.sideB=sideB;
        this.sideC=sideC;  
    }
    public override double calculateArea()
    {
        double s=(sideA+sideB+sideC)/2;
        return Math.Sqrt(s*(s-sideA)-(s-sideB)*(s-sideC));
    }
    public override double calculatePerimeter()
    {
        return sideA+sideB+sideC;
    }
}
class Program
{
    static void Main()
    {
      Circle circle=new Circle(4.0);
      Triangle triangle=new Triangle(3.0,4.0,5.0); 
      Console.WriteLine("circle");
      Console.WriteLine($"area:{circle.calculateArea()}"); 
      Console.WriteLine($"perimeter:{circle.calculatePerimeter()}"); 
      Console.WriteLine();
     
      Console.WriteLine("triangle");
      Console.WriteLine($"area:{triangle.calculateArea()}"); 
      Console.WriteLine($"perimeter:{triangle.calculatePerimeter()}"); 
      Console.WriteLine();
    }
}





