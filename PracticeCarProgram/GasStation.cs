using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCarProgram
{
    internal class GasStation
    {
        public int Served { get; set; }
        public int FuelSold { get; set; }



        public GasStation()
        {
            Served = 0;
            FuelSold = 0;


        }
        public void FillUp(Car car)
        {
            car.Fuel = 25;
            FuelSold += 25;
            Served++;
            Console.WriteLine("...We filled up the fuel for you!");

        }



    }
}
