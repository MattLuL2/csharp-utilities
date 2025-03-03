using System.ComponentModel.DataAnnotations;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //although Shape is an abstract is can be used as a reference type
            //any child class of Shape is also a Shape
            double length = 2;
            double width = 3;
            List<Shape> shapes = new List<Shape>
            {
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Triangle($"triangle – bas:{length}, hei:{width}", length, width),
                //doubling width and length
                new Triangle($"triangle – bas:{length *= 2}, hei:{width *= 2}", length, width),
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Ellipse($"ellipse – min:{length}, maj:{width}", length, width),
                new Diamond($"diamond – min:{length}, maj:{width}", length, width)
            };

            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
        }

        public abstract class Shape
        {
            private string name;
            protected abstract double Area { get; }

            protected Shape(string name)
            {
                this.name = name;
            }

            public override string ToString()
            {
                //Slightly different format than the example but I think it looks better
                return $"{name} area:{Area:F2}";
            }
        }

        public class Square : Shape
        {
            protected double Length { get; }
            protected override double Area
            {
                get
                {
                    return Length * Length;
                }
            }

            public Square(string name, double length) : base(name)
            {
                Length = length;
            }

        }

        public class Circle : Square
        {
            protected override double Area
            {
                get
                {
                    return Math.PI * Length * Length;
                }
            }
            public Circle(string name, double length) : base(name, length)
            {

            }
        }

        public class Rectangle : Shape
        {
            protected double Width { get; }
            protected double Length { get; }
            protected override double Area
            {
                get
                {
                    return Width * Length;
                }
            }

            public Rectangle(string name, double length, double width) : base(name)
            {
                Length = length;
                Width = width;
            }
        }

        public class Ellipse : Rectangle
        {
            protected override double Area
            {
                get
                {
                    return Math.PI * Width * Length;
                }
            }
            public Ellipse(string name, double length, double width) : base(name, length, width)
            {
            }
        }

        public class Triangle : Rectangle
        {
            protected override double Area
            {
                get
                {
                    return 0.5 * Width * Length;
                }
            }

            public Triangle(string name, double length, double width) : base(name, length, width)
            {

            }
        }

        public class Diamond : Rectangle
        {
            protected override double Area
            {
                get
                {
                    return Width * Length;
                }
            }
            public Diamond(string name, double length, double width) : base(name, length, width)
            {
            }
        }
    }
}
