using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            Console.WriteLine(CarLot.numberOfCars);
            Car car2 = new Car() { Year = 2014, Make = "Toyota", Model = "Corolla", EngineNoise = "mmmmrmmrmrmrmm", HonkNoise = "AWWWOOOOOGGGGAAAAAAA", IsDrivable = true };
            Console.WriteLine(CarLot.numberOfCars);
            Car car3 = new Car(2020, "Audi", "A4", "vvvvvvrrrvvvrvmmmm", "Le Honk", true);
            Console.WriteLine(CarLot.numberOfCars);

            car1.Year = 2002;
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.EngineNoise = "Rrrrrrr";
            car1.HonkNoise = "Honk";
            car1.IsDrivable = true;

           // car1.MakeEngineNoise(car1.EngineNoise);
           // car2.MakeEngineNoise(car2.EngineNoise);
           // car3.MakeEngineNoise(car3.EngineNoise);

           // car1.MakeHonkNoise(car1.HonkNoise);
           // car2.MakeHonkNoise(car2.HonkNoise);
           // car3.MakeHonkNoise(car3.HonkNoise);

            foreach (Car car in CarLot.CarList)
            {
                Console.WriteLine($"Year: {car.Year}\t Make: {car.Make}\t Model: {car.Model}");
            }

        }
    }
}
