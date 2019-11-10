using System;

namespace OB
{


    class Program
        {
            static void Main(string[] args)
            {
                //Loome objekti, käsk objekti loomiseks
                Animal nurr = new Animal();
                nurr.name = "Nurr";
                nurr.age = 15;
                nurr.levelOfHappiness = 0.1;

                nurr.PrintAnimalBaseInfo();

                Dog muki = new Dog();
                muki.name = "Muki";
                muki.age = 1;
                muki.levelOfHappiness = 0.3;
                muki.spotCount = 5;
                muki.PrintAnimalBaseInfo();

                Cat miisu = new Cat();
                miisu.name = "Miisu";
                miisu.age = 2;
                miisu.levelOfHappiness = 0.5;
                miisu.levelOfCutness = 1;
                miisu.PrintAnimalBaseInfo();
                for (int i = 0; i < 10; i++)
                {
                    miisu.Meow();

                }
                miisu.ShowLevelOfCutness();
                //miisu = null;
                //miisu.PrintAnimalBaseInfo();


                //Dogbarks
                for (int i = 0; i < 20; i++)
                {
                    muki.Bark();
                }
                miisu.HearBarks(muki.numberOfBarks);
                if (miisu.levelOfHappiness < 0)
                {
                    Console.WriteLine($"{miisu.name} died of stress.");
                    miisu = null;
                }

                muki.ShowLevelOfHappiness();
                muki.ShowNumberOfDogSpots();









            }
    }
    
}
