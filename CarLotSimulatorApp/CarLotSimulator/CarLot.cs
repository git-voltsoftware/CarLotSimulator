using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot() { cars = new List<Car>(); } // Constrtuctor

        public List<Car> cars { get; set; }
        public void AddCar( Car car)
        {
            cars.Add(car);
        }

        public void PrintCarDetails()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
            }
        }
    }
}
