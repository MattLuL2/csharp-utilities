using System.Runtime.CompilerServices;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mazda = new Car("Mazda3",2018,10000,true);
            Car toyota = new Car("Matrix", 2010, 4000, false);
            Car honda = new Car("Odessey", 2007, 3000, false);
            Car tesla = new Car("Model X", 2023, 65000, true);

            Console.WriteLine(mazda.ToString());
            Console.WriteLine(toyota.ToString());
            Console.WriteLine(honda.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
    internal class Car
    {
        private int year;
        private string model;
        private bool isDrivable;
        private double price;

        public Car(string model, int year, double price, bool isDrivable = true)
        {
            this.model = model;
            this.year = year;
            this.price = price;
            this.isDrivable = isDrivable;
        }

        public override string ToString()
        {
            return $"{model}, {year}, ${price}. Is Drivable? {isDrivable}";
        }
    }
}
