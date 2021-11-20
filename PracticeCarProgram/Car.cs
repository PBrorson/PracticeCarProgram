using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCarProgram
{
    internal class Car
    {
        public int Fuel { get; set; }
        public string Brand { get; set; }    
        public bool Damage { get; set; }    
        public int TravelDistance { get; set; }


        public Car(string brand, int fuel , int traveldistance, bool damage)
        {
            this.Brand = brand;
            this.Fuel = fuel;   
            this.TravelDistance = traveldistance;
            this.Damage = damage;

        }
        public void Drive (Car car, Random rnd)
        {
            car.TravelDistance++;
            car.Fuel--;

            if (rnd.Next(0,100) <=10)
            {
                car.Damage = true;
            }
        }
    
    
    
    }
}
