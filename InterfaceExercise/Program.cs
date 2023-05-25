using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var vehicles = new List<IVehicle>();

            Suv durango = new Suv()
            {
                Year = 2000,
                Make = "Dodge",
                Model = "Durango",
                Color = "Red",
                Price = 3500,
                CargoSize = 20,
                Logo = "Ram",
                Slogan = "Born Dodge"
            };
            vehicles.Add(durango);

            Truck sierra = new Truck()
            {
                Year = 2003,
                Make = "Chevrolet",
                Model = "Sierra",
                Color = "Blue",
                Price = 2700,
                BedSize = 24,
                Logo = "Tie",
                Slogan = "Find New Roads",
            };
            vehicles.Add((sierra));

            Car acclaim = new Car()
            {
                Year = 1989,
                Make = "Plymouth",
                Model = "Acclaim",
                Color = "Maroon",
                Price = -500,
                TrunkSize = 22,
                Logo = "Boat",
                Slogan = "That's Plymouth"
            };
            vehicles.Add((acclaim));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This {vehicle.Color} {vehicle.Year} {vehicle.Make} {vehicle.Model} can be yours for ${vehicle.Price}."); 
            }
            Console.WriteLine($"Yes you read that right!  We will give you $500 to get this {acclaim.Year} {acclaim.Make} {acclaim.Model} off of our lot! " +
                $"It has a trunk size of{acclaim.TrunkSize} square feet!  For comparison, the Sierra has a bed size of {sierra.BedSize} square feet, and the Durango has " +
                $"a rear cargo size of {durango.CargoSize} square feet.");
        }   
            
    }
}
