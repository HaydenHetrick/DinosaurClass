using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dino1 = new Dinosaur("Short Arms", "T-Rex", "Carnivore", 65);
            var dino2 = new Dinosaur("Leaf Eater", "Stegosaurus", "Herbivore", 155);
            var dino3 = new Dinosaur("I am Acid Spitter Jurasic Park 1 Villian", "Velociraptor", "Carnivore", 85);  

            dino1.Display();
            dino1.Roar();
            dino2.Display();
            dino2.Roar();
            dino3.Display();
            dino3.Roar();

            Console.ReadLine();
        }
    }
}
