using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var brittanysCar = new Car();
            brittanysCar.Year = 2008;
            brittanysCar.Make = "Toyota";
            brittanysCar.Model = "Yaris";
            brittanysCar.IsDriveable = true;

            //Console.WriteLine($"{brittanysCar.Year}\n{brittanysCar.Make}\n{brittanysCar.Model}\n{brittanysCar.MakeEngineNoise()}\n{brittanysCar.MakeHonkNoise()}");



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car yoongisCar = new Car() { 
                Year = 2022,
                Make = "Lamborghini",
                Model = "Aventador SVJ Roadster",
                IsDriveable = true,
                EngineNoise = "purrrrr",
                HonkNoise = "honk"};

            //Console.WriteLine($"{yoongisCar.Year}\n{yoongisCar.Make}\n{yoongisCar.Model}\n{yoongisCar.EngineNoise}\n{yoongisCar.HonkNoise}");

            Car jiminsCar = new Car(2018, "Mercedes", "Benz", "vroom vroom", "beep beep", true);
            //Console.WriteLine($"{jiminsCar.Year}\n{jiminsCar.Make}\n{jiminsCar.Model}\n{jiminsCar.EngineNoise}\n{jiminsCar.HonkNoise}");

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            CarLot brittanysCarLot = new CarLot();
            brittanysCarLot.carsList.Add(brittanysCar);
            brittanysCarLot.carsList.Add(yoongisCar);
            brittanysCarLot.carsList.Add(jiminsCar);

            brittanysCarLot.GetCars();

        }  
        

            //*************BONUS X 2*************//


        
    }
}
