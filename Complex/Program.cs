namespace Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);
            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
            Complex c3 = c1 + c2;
            Console.WriteLine($"{c3.Modulus:f2}");
            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
        }
    }

    public class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Modulus
        {
            get
            {
                return Math.Sqrt((Real * Real) + (Imaginary * Imaginary));
            }
        }
        public static Complex Zero 
        { 
            get 
            {
                return new Complex(0, 0);
            }
        }

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"({Real}, {Imaginary})";
        }
        public static Complex operator + (Complex lhs,Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            if (lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
