using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car  //Create a seperate class file called Car
    {
        public Car()
        {

        }
        public Car(int year, string make, String model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

      
        }
           //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            public string MakeEngineNoise()
            {
                return "Vroom Vroom";
            }
            public string MakeHonkNoise()
            {
                return "beep beep";
            }
            //The methods should take one string parameter: the respective noise property






        
    }
}
