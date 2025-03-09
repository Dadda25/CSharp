using System;
using System.Collections.Generic;

interface IShape
{
    double Area { get; }
    bool IsValid();
    string GetDescription();
}

abstract class Shape : IShape
{
    public abstract double Area { get; }
    public virtual bool IsValid()
    {
        return true;
    }
    public virtual string GetDescription()
    {
        return "Unknown shape";
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width {  get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Area => Length * Width;

    public override bool IsValid()
    {
        return Length > 0 && Width > 0;
    }
    public override string GetDescription()
    {
        return $"此矩形的长为：{Length}，宽为：{Width}";
    }
}

class Square:Rectangle
{
    public Square(double side) : base(side, side) { }
    public override double Area => Length * Length;
    public override bool IsValid()
    {
        return Length > 0;
    }
    public override string GetDescription()
    {
        return $"此正方形边长为：{Length}";
    }
}

class Triangle:Shape
{
    public double Base { get; set; }
    public double Height {  get; set; }

    public Triangle (double baseLength,double height)
    {
        Base = baseLength;      
        Height = height;
    }
    public override double Area => Base * Height * 0.5;

    public override bool IsValid()
    {
        return Base > 0 && Height > 0;
    }
    public override string GetDescription()
    {
        return $"此三角形的底为：{Base}，高为：{Height}";
    }
}

class ShapeFactory
{
    private static Random random = new Random();
    public static IShape CreateShape()
    {
        int shapeType = random.Next(0, 3);
        switch(shapeType)
        {
            case 0:
                return new Rectangle(random.Next(1, 10), random.Next(1, 10));
            case 1:
                return new Square(random.Next(1, 10));
            case 2:
                return new Triangle(random.Next(1, 10), random.Next(1, 10));
            default:
                return null;
        }
    }
}

class Progarm
{
    static void Main(string[] args)
    {
        List<IShape>shapes = new List<IShape>();

        for(int i = 0; i < 10; i++)
        {
            IShape shape=ShapeFactory.CreateShape();
            if(shape.IsValid())
            {
                shapes.Add(shape);
            }
        }

        double totalArea = 0;
        Console.WriteLine("随机创建的10个形状对象：");
        foreach(var shape in shapes)
        {
            Console.WriteLine(shape.GetDescription());
            totalArea += shape.Area;
        }

        Console.WriteLine($"所有形状的面积之和：{totalArea:F2}");
    }
}
