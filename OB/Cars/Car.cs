using System;

namespace Cars
{
    class Car
    {
        public string model;
        public string mark;
        public string color;
        public string regNumber;
        public int odo = 0;

        public void Drive()
        {
            odo += 100;
        }

        public void ShowOdo()
        {
            Console.WriteLine($"The car has driven {odo}.");

        }
    }
}
