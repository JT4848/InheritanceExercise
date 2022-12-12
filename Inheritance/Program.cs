using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.DoesItFly = false;
            bird1.Diet = "seeds";
            bird1.IsFast = true;
            bird1.IsLarge = true;
            bird1.Species = "bird";
            bird1.Weight = "100 to 120";
            bird1.IsUgly = false;
            bird1.Name = "emu";
            Console.WriteLine($"If you look to the left side of the bus you will see what is called a {bird1.Name}, can anyone guess if they fly " +
                $"or not? Thats   right the answer is {bird1.DoesItFly}, it's {bird1.IsFast} what you hear aboout there speed, they can run up to 31 " +
                $"miles per hour! Now obviusly he is in the {bird1.Species} species, so like most birds he loves to eat {bird1.Diet}. As you can see " +
                $"what you've heard is {bird1.IsLarge} about   there size, they are about 5 foot 7 inches tall and they weigh {bird1.Weight} pounds! Pretty big " +
                $"for a bird, i personally   think they're cute, other people say they're ugly, i say they're {bird1.IsUgly}");


            Console.WriteLine("---------------------------------------------------");


            Reptile reptile1 = new Reptile();
            reptile1.IsScaley = true;
            reptile1.Diet = "spiders";
            reptile1.IsFast = true;
            reptile1.Weight = "4.5 pounds";
            reptile1.Length = "Males get up to 4 foot 3 inches, females get up to 3 foot 3 inches";
            reptile1.IsUgly = false;
            reptile1.Species = "reptile";
            reptile1.Name = "black iguana";
            Console.WriteLine($" Welcome to your tour in the Marino Ballena National Park! We are going to see a {reptile1.Name} today, It's {reptile1.IsFast}" +
                $" that they are the fastest lizard in the world running at about 30 miles per hour! Pretty easy to run that fast when you're only  {reptile1.Weight}." +
                $"{reptile1.Length}, pretty big for a lizard right! It is {reptile1.IsScaley} that they have scales so of course they are in the {reptile1.Species}" +
                $" species. People think that they are ugly but i say that      they're {reptile1.IsUgly}, they love to climb tree's or be on the ground were they find" +
                $" most of there food, one of there favorites  are {reptile1.Diet}!");
        }
    }
}
