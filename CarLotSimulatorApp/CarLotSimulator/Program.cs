using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise Instructions
            /*Create a separate class file called Car
             * Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
             * Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
             * The methods should take one string parameter: the respective noise property
             * Now that the Car class is created we can instanciate 3 new cars
             * Set the properties for each of the cars
             * Call each of the methods for each car
             * *************BONUS*************
             * Set the properties utilizing the 3 different ways we learned about, one way for each car
             * *************BONUS X2*********
             * Create a CarLot class
             * It should have at least one property: a List of cars
             * Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
             * At the end iterate through the list printing each of car's Year, Make, and Model to the console*/
            #endregion

            #region Static Keyword Exercise2 Instructions
            /*create a CarLot class with a static field called numberOfCars.
             * Have this number only increment when in our program we create a new Car. 
             * From there create 3 cars in the Main() and then each time you create a car, 
             * - do a Console.WriteLine() printing the current number of cars in the car lot.*/

            #endregion

            CarLot brittanysCarLot = new CarLot();

            var brittanysCar = new Car();
            brittanysCar.Year = 2008;
            brittanysCar.Make = "Toyota";
            brittanysCar.Model = "Yaris";
            brittanysCar.IsDriveable = true;
            brittanysCarLot.carsList.Add(brittanysCar);
            brittanysCarLot.GetCar(brittanysCar);
            Console.WriteLine($"Number of cars in Car lot: {CarLot.NumberOfCars}");

            Car yoongisCar = new Car() 
            {  
                Year = 2022,
                Make = "Lamborghini",
                Model = "Aventador SVJ Roadster",
                IsDriveable = true,
                EngineNoise = "purrrrr",
                HonkNoise = "honk"
            };          
            brittanysCarLot.carsList.Add(yoongisCar);
            brittanysCarLot.GetCar(yoongisCar);
            Console.WriteLine($"Number of cars in Car lot: {CarLot.NumberOfCars}");

            Car jiminsCar = new Car(2018, "Mercedes", "Benz", "vroom vroom", "beep beep", true);
            brittanysCarLot.carsList.Add(jiminsCar);         
            brittanysCarLot.GetCar(jiminsCar);
            Console.WriteLine($"Number of cars in Car lot: {CarLot.NumberOfCars}");

            Console.WriteLine("\n-------------------------------------------------------------------");
            brittanysCarLot.GetCars();
            Console.WriteLine($"\nTotal cars in Car lot: {CarLot.NumberOfCars}");
        }    
    }
}
