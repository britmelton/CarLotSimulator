using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car 
    {
        public Car()
        {
            CarLot.NumberOfCars++;
        }
        public Car(int year, string make, String model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.NumberOfCars++;
        }
            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }
            public string MakeEngineNoise()
            {
                return "Vroom Vroom";
            }
            public string MakeHonkNoise()
            {
                return "beep beep";
            } 
    }
}
