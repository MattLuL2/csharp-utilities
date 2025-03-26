namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawables = new List<IDrawable>();
            drawables.Add(new DrawableRectangle("red"));
            drawables.Add(new DrawableEllipse("yellow"));
            drawables.Add(new DrawableBezier("blue"));
            drawables.Add(new DrawableArc("white"));
            drawables.Add(new DrawableLine("black"));
            foreach (IDrawable drawable in drawables)
            {
                drawable.Draw();
                if (drawable is IWriteable)
                {
                    IWriteable writable = drawable as IWriteable;
                    writable.Write();
                }
            }
        }

        interface IDrawable
        {
            void Draw();
        }

        interface IWriteable
        {
            void Write();
        }

        abstract class Primitive
        {
            protected string color;

            public Primitive(string color)
            {
                this.color = color;
            }
        }

        class DrawableRectangle: Primitive, IDrawable, IWriteable
        {
            public DrawableRectangle(string color) : base(color)
            {
            }
            public void Draw()
            {
                Console.WriteLine($"Drawing a {color} Rectangle");
            }

            public void Write()
            {
                Console.WriteLine($"Saving a {color} Rectangle to a file");
            }
        }

        class DrawableEllipse : Primitive, IDrawable
        {
            public DrawableEllipse(string color) : base(color)
            {

            }
            public void Draw()
            {
                Console.WriteLine($"Drawing a {color} Ellipse");
            }
        }

        class DrawableLine : IDrawable, IWriteable
        {
            protected string color;
            public DrawableLine (string color)
            {
                this.color = color;
            }

            public void Draw()
            {
                Console.WriteLine($"Drawing a {color} Line");
            }

            public void Write()
            {
                Console.WriteLine($"Saving a {color} Line to a file");
            }
        }

        class DrawableBezier:IDrawable, IWriteable
        {
            protected string color;
            public DrawableBezier(string color)
            {
                this.color = color;
            }
            public void Draw()
            {
                Console.WriteLine($"Drawing a {color} Bezier");
            }
            public void Write()
            {
                Console.WriteLine($"Saving a {color} Bezier to a file");
            }
        }

        class DrawableArc : Primitive,IDrawable, IWriteable
        {
            public DrawableArc(string color) : base(color)
            {
            }
            public void Draw()
            {
                Console.WriteLine($"Drawing a {color} Arc");
            }
            public void Write()
            {
                Console.WriteLine($"Saving a {color} Arc to a file");
            }
        }
    }
}
