using System;

namespace OB
{
    class Cat : Animal
    {
        public double levelOfCutness;
        public void Meow()
        {
            Console.WriteLine("Meow");
            levelOfCutness -= 0.1;
            levelOfHappiness += 0.1;
            /*int randomNumberOfMeow;
            Random rndNumber = new Random();
            randomNumberOfMeow = rndNumber.Next(0, 6);
            levelOfCutness -= randomNumberOfMeow;*/
        }
        public void ShowLevelOfCutness()
        {
            Console.WriteLine($"Level of cutness: {levelOfCutness}.");
        }
        public void HearBarks(int numberOfBarks)
        {
            levelOfHappiness -= 0.1 * numberOfBarks;
        }
    }
}
