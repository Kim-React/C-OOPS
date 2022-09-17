using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.OOPS
{
    public class Car
    {
        public string Color = "red";
        public string model = "";

        public Car(string modelName)
        {
            model = modelName;
        }

        public void Speed()
        {
            Console.WriteLine("Vehicle is going at its full speed");
        }
    }
}
