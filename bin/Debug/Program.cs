using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a car object
            Car testCar = new Car("BMW", "1 Series", "LN62 HFW", 152000.00);
            //testCar.Details();
            Console.WriteLine(testCar);

           
        }
    }
}
