using System;

namespace treehouseVirtualPetC
{
    class Program
    {
        static void Main(string[] args)
        {
            WellnessQoutient healthyPetty = new WellnessQoutient(50);

            Cat sammy = new Cat();

            Console.WriteLine("{0} {1} {2}", sammy.Hunger, sammy.Affection, sammy.Sleep);

        }
    }
}
