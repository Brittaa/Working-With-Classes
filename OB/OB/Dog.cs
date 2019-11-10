using System;

namespace OB
{
    //Inheritance
    class Dog : Animal //saab kasutada koeral samu muutujaid
    {
        //lisaomadus
        public int spotCount = 0;
        public int numberOfBarks = 0;
        public void Bark()
        {
            Console.WriteLine("Wuf");
            numberOfBarks++;
            levelOfHappiness += 0.1;
            int randomNumberOfSpots;
            Random rndNumber = new Random();
            randomNumberOfSpots = rndNumber.Next(0, 6);
            spotCount += randomNumberOfSpots;
        }
        public void ShowNumberOfDogSpots()
        {
            Console.WriteLine($"{name} has now {spotCount} number of spots.");
        }
    }
}
