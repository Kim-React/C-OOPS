using OOPS.OOPS;
using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car("Mustang"); ;
            //Console.WriteLine(car1.model);

            //Car car2 = new Car("Ford"); ;
            //Console.WriteLine(car2.model);


            static void Main(string[] args)
            {    // Create a myCar object
                Car myCar = new Car();
                myCar.honk();
                Console.WriteLine(myCar.brand + " " + myCar.modelName);
            }

        }
    }
}
