using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }


        public Car()
        {
            CarLot.CarList.Add(this);
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDrivable = isDrivable;
            CarLot.numberOfCars++;
            CarLot.CarList.Add(this);
        }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
