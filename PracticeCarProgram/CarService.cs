using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCarProgram
{
    internal class CarService
    {

        public int Service { get; set; }


        public CarService()
        {
            Service = 0;
        }
            
        public void Repair(Car car)
        {
            car.Damage = false;
            Service++;
            Console.Write("...We fixed it!");
        }



    }
}
