using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Superb";
            myCar.mark = "Skoda";
            myCar.color = "pink";
            myCar.regNumber = "123ABS";
            myCar.odo = 400;

            for(int i = 0; i < 10; i++)
            {
                myCar.Drive();
            }
            myCar.ShowOdo();

        }
    }
}
