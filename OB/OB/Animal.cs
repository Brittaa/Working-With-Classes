using System;

namespace OB
{
    class Animal
    {
        //Working with classes
        //Objekt orientiiritud progammeerimine
        public string name;
        public int age;
        public double levelOfHappiness;
        //muutujad nimeta kõigepealt

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
            // meetod

        }

        public void ShowLevelOfHappiness()
        {
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
        //meetod

    }
}
