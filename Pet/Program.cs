namespace Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet poppy = new Pet("Poppy", 2, "a tall, wild, and cute dog");
            Pet roxy = new Pet("Roxy", 10, "a hunky calm dog");
            Pet cooper = new Pet("Cooper", 3, "a small, cute, and playful dog");
            Pet sunny = new Pet("Sunny", 1, "a small, roudy dog (RIP)");

            List<Pet> pets = new List<Pet> { poppy, roxy, cooper, sunny };

            poppy.SetOwner("Sage");
            roxy.SetOwner("Dad");
            cooper.SetOwner("Mom");
            sunny.SetOwner("Dad");
            poppy.Train();
            roxy.Train();
            cooper.Train();

            foreach(Pet dog in pets)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine("Please enter an owner's name to see their pet(s):");
            string owner = Console.ReadLine();
            foreach (Pet dog in pets)
            {
                if (dog.Owner == owner)
                {
                    Console.WriteLine(dog);
                }
            }
        }

        public class Pet
        {
            public string Name { get; }
            public string Owner { get; private set; }
            public int Age { get; }
            public string Description { get; }
            public bool IsHouseTrained { get; private set; }

            public Pet(string name, int age, string description)
            {
                Name = name;
                Age = age;
                Description = description;
                Owner = "no one";
                IsHouseTrained = false;
            }

            public override string ToString()
            {
                string houseTrained = IsHouseTrained ? "is" : "is not";
                return $"{Name} ({Age} yrs) owned by {Owner} {houseTrained} house trained. {Description}";
            }

            public void SetOwner(string owner)
            {
                Owner = owner;
            }

            public void Train()
            {
                IsHouseTrained = true;
            }

        }
    }
}
