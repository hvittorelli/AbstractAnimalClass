using System;
using System.Xml.Linq;

namespace AbstractAnimalClass
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Program
    {
        class Whale : Animal
        {
            public override string Name { get; set; }
            public string Type { get; set; }
            public int Weight { get; set; }

            public Whale() 
            {
                Name = string.Empty;
                Type = string.Empty;
                Weight = 0;
            }

            public Whale (string name, string type, int weight)
            {
                Name = name;
                Type = type;
                Weight = weight;
            }

            public override string Describe() 
            {
                return "I am a " + Type + " whale. My name is " + Name + ". I weigh " + Weight + " pounds.";
            }
        }
        static void Main(string[] args)
        {
            Whale killer = new Whale();
            killer.Name = "Spot";
            killer.Type = "Orca";
            killer.Weight = 15000;

            Whale humpy = new Whale("Lumpy", "Humpback", 70000);
            Console.WriteLine(killer.Describe());
            Console.WriteLine(humpy.Describe());
        }
    }
}