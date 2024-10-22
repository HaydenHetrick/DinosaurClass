using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurClass
{
    internal class Dinosaur
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Diet{ get; set; }
        public int Age { get; set; }

        public Dinosaur(string name, string species, string diet, int age)
        {
            Name = name;
            Species = species;
            Diet = diet;
            Age = age;
        }

        public void Roar()
        {
            Console.WriteLine($"ROAR! IM {Name}, IM ALSO A {Species}, I AM A {Diet}, AND IM {Age} OLD.s");
        }


        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Diet: " + Diet);
            Console.WriteLine("Age: " + Age);
        }
    }
}
