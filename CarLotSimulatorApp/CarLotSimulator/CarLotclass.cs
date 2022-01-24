using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot //Create a CarLot class
    {
        public CarLot()
        {
          
        }
        public static int NumberOfCars { get; set; }
     
      public List <Car> carsList = new List<Car>(); //It should have at least one property: a List of cars

        public void GetCars()
        {
            foreach (Car car in carsList)
            {
                Console.WriteLine($"\n{car.Year}\n{car.Make}\n{car.Model}");
            }
        }
        

        //At the end iterate through the list printing each of car's Year, Make, and Model to the console

    }
}
