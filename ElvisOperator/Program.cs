using System;
using System.Collections.Generic;
using System.Linq;


namespace ElvisOperator
{
    class Program
    {
        class SuperHero
        {
            public string Alias { get; set; }

            public SuperVehicle Vehicle { get; set; }
        }

        class SuperVehicle
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<SuperHero> superHeros = new List<SuperHero>();

            SuperVehicle batmobile = new SuperVehicle { Name = "Batmobile" };
            SuperHero batman = new SuperHero { Alias = "Batman", Vehicle = batmobile };
            SuperHero aquaman = new SuperHero { Alias = "Aquaman" };

            superHeros.Add(batman);
            superHeros.Add(aquaman);

            foreach(SuperHero superHero in superHeros)
            {
                Console.Write($"I'm {superHero.Alias}.");

                // Null conditional operator tests for null before accessing a member of an instance
                string vehicle = superHero?.Vehicle?.Name;

                if(vehicle != null)
                {
                    Console.WriteLine($"My vehicle is {superHero.Vehicle.Name}");
                } else
                {
                    Console.WriteLine("I have no vehicle :(");
                }
            }

            Console.ReadLine();
        }
    }
}
