using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDetails
{
    public class Car
    {
        //Fields
        public string make;
        public string model;
        public string registration;
        public int year;
        public double purchasePrice;
        
       
        //Constructor
        public Car(string make, string model, string registration, double purchasePrice)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            //this.year = year;
            this.purchasePrice = purchasePrice;
        }
        
        //Calculate vehicle's current value     

        public double Depreciate(int year, double costOfVehicle)
        {
            DateTimeOffset yearNow = new DateTime();

            double newCurrentValue;
            if ((yearNow.Year - year) < 5)
            {
                newCurrentValue = costOfVehicle * (49 / 100);
            }

            else if ((yearNow.Year - year) <= 4)
            {
                newCurrentValue = costOfVehicle * (58 / 100);
            }
            else if ((yearNow.Year - year) <= 3)
            {
                newCurrentValue = costOfVehicle * (69 / 100);
            }
            else if ((yearNow.Year - year) <= 2)
            {
                newCurrentValue = costOfVehicle * (81 / 100);
            }

           else if ((yearNow.Year - year) <= 1)
            {
               newCurrentValue = costOfVehicle * (91 / 100);
            }
           
            else
            {
                newCurrentValue = costOfVehicle * (40 / 100);
            }
            return newCurrentValue;
        }

        //override ToString
        public override string ToString()
        {
            int registrationYr = CarYear(registration);
            double currentCost = Depreciate(registrationYr, purchasePrice);
            string message = $"You own a {make} {model} with registration number {registration}, initial registration in the year {registrationYr} and a current value of £{currentCost}";
            return message;
        }

        // Calculate year of the car
        public int CarYear(string registration)
        {
            //New style registrations
            
            string regNum;

            if (registration.Length > 7)
            {
                regNum = registration.Substring(2, registration.Length - 5);
            }
            else
            {
                regNum = registration.Substring(1, registration.Length - 5);
            }

            //Console.WriteLine(regNum.GetType());

            //registration = "LN62 HFW";
            int.TryParse(regNum, out int yrOfReg);
            //Console.WriteLine(yrOfReg.GetType());
            
            if (yrOfReg <= 30)
            {
                yrOfReg +=  2000;

            }
            else if (yrOfReg <= 79)
            {
                yrOfReg += 2000 - 50;
         
            }
            //Console.WriteLine(yrOfReg);

            return yrOfReg;
        }
    }
}
