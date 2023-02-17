using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        public Car() { } // Constructor


        //properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
            {
                Console.WriteLine("The " + Make + " " + Model + " engine goes " + EngineNoise);
            }

        public void MakeHonkNoise()
        {
                Console.WriteLine("The " + Make + " " + Model + " honk goes " + HonkNoise);
        }
        



    }
}
