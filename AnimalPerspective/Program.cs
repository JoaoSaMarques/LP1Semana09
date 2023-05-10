using System;

namespace AnimalPerspective
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create new animal list
            Animal[] animals = new Animal[10];
            Random random = new Random();

            for (int i = 0; i < animals.Length; i++)
            {
                int randomNumber = random.Next(1, 5);
                switch (randomNumber)
                {
                    case 1:
                        animals[i] = new Dog();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Bat();
                        break;
                    case 4:
                        animals[i] = new Bee();
                        break;
                }
                
            }

            //For each animal
            foreach (Animal animal in animals)
            {
                //Play a sound corresponding to animal
                Console.WriteLine("Sound: " + animal.Sound());
                //If the animal is a mammal, put number of nipples.
                if (animal is IMammal mammal)
                {
                    Console.WriteLine("Number of nipples: " + mammal.NumberOfNipples);
                }

                //If the animal can fly then print their wings
                if (animal is ICanFly flyable)
                {
                    Console.WriteLine("Number of wings: " + flyable.NumberOfWings);
                }

                //Print output
                Console.WriteLine();
            }
        }
    }
}

