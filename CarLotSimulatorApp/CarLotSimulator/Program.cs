using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            Car car2 = new Car() { Year = 2014, Make = "Toyota", Model = "Corolla", EngineNoise = "mmmmrmmrmrmrmm", HonkNoise = "AWWWOOOOOGGGGAAAAAAA", IsDrivable = true };
            Car car3 = new Car(2020, "Audi", "A4", "vvvvvvrrrvvvrvmmmm", "Le Honk", true);

            car1.Year = 2002;
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.EngineNoise = "Rrrrrrr";
            car1.HonkNoise = "Honk";
            car1.IsDrivable = true;

            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            //*************BONUS X 2*************//

            CarLot carList = new CarLot();
            carList.CarList.Add(car1);
            carList.CarList.Add(car2);
            carList.CarList.Add(car3);

            foreach (Car car in carList.CarList)
            {
                Console.WriteLine($"Year: {car.Year}\t Make: {car.Make}\t Model: {car.Model}");
            }

        }
    }
}
