using AnimalHierarchy.Bird;
using AnimalHierarchy.Fish;
using AnimalHierarchy.Mammal;

namespace AnimalHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listOfAnimals = new List<Animal>()
            {
                new Cat("Stepan", 2),
                new Bird.Bird(),
                new Owl(),
                new Fish.Fish(),
                new Dog("Patron", 4),
                new Dog("Sharik", 100),
                new Shark("Baby shark :)", 1),
                new Animal("Wolf", 5),
                new Eagle("American eagle", 15),
                new Dorado("Koko", 99),
                new Mammal.Mammal()
            };

            foreach (Animal animal in listOfAnimals)
            {
                animal.Speak();
                animal.Move();
                Console.WriteLine();
            }
        }
    }
}