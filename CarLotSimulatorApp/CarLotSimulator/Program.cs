using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carlot instatiation
            CarLot myLot = new CarLot();

            Car myCar = new Car() { Make = "Toyota", Model = "Camry", Year = 2023, EngineNoise = "Vroom", HonkNoise = "Honk", IsDriveable= true, InStock=true };

            myLot.AddCar(myCar);
            myLot.PrintCarDetails();
        }
    }
}
