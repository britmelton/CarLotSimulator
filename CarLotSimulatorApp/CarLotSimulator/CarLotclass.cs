﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
          
        }
        public static int NumberOfCars { get; set; }
     
      public List <Car> carsList = new List<Car>(); 
        public void GetCar(Car thisCar)
        {
            Console.WriteLine($"\n{thisCar.Year}\n{thisCar.Make}\n{thisCar.Model}\n");
        }

        public void GetCars()
        {
            foreach (Car car in carsList)
            {
                Console.WriteLine($"\n{car.Year}\n{car.Make}\n{car.Model}");              
            }
        }
    }
}
