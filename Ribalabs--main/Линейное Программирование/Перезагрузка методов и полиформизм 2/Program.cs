using System;

namespace VolumeCalculationPolymorphism
{
    abstract class Shape
    {
        public abstract double CalculateVolume();
    }

    class Cube : Shape
    {
        private double side;

        public Cube(double a)
        {
            side = a;
        }

        public object Side { get; internal set; }

        public override double CalculateVolume()
        {
            return side * side * side;
        }
    }

    class Box : Shape
    {
        private double length;
        private double width;
        private double height;

        public Box(double a, double b, double c)
        {
            length = a;
            width = b;
            height = c;
        }

        public object Length { get; internal set; }
        public object Width { get; internal set; }
        public object Height { get; internal set; }

        public override double CalculateVolume()
        {
            return length * width * height;
        }
    }

    class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public object Height { get; internal set; }
        public object Radius { get; internal set; }

        public override double CalculateVolume()
        {
            return Math.PI * radius * radius * height;
        }
    }

    class Sphere : Shape
    {
        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }

        public object Radius { get; internal set; }

        public override double CalculateVolume()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет объемов с использованием полиморфизма:");

            Shape[] shapes = new Shape[4];
            shapes[0] = new Cube(2);
            shapes[1] = new Box(3, 4, 5);
            shapes[2] = new Cylinder(3, 5);
            shapes[3] = new Sphere(3);

            foreach (var shape in shapes)
            {
                string description = "";
                double volume = shape.CalculateVolume();

                if (shape is Cube cube)
                {
                    description = $"Объем куба со стороной {cube.Side} равен {volume}.";
                }
                else if (shape is Box box)
                {
                    description = $"Объем параллелепипеда со сторонами {box.Length}, {box.Width} и {box.Height} равен {volume}.";
                }
                else if (shape is Cylinder cylinder)
                {
                    description = $"Объем цилиндра с радиусом {cylinder.Radius} и высотой {cylinder.Height} равен {volume:F2}.";
                }
                else if (shape is Sphere sphere)
                {
                    description = $"Объем шара с радиусом {sphere.Radius} равен {volume:F2}.";
                }

                Console.WriteLine(description);
            }
        }
    }
}