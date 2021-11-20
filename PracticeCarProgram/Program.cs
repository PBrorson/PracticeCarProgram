using PracticeCarProgram;

Car[] cars = { new Car("Saab", 15, 35, false),
               new Car ("Volvo", 20, 19, true),
               new Car ("Toyota", 25, 44, false)

};

Random rnd = new Random();

CarService carService = new CarService();
GasStation gasStation = new GasStation();   

while (true)
{
    foreach (var car in cars)
    {
        car.Drive(car,rnd);
        if (car.Fuel <10)
        {
            Console.Write("The car was running out of fuel!");
            gasStation.FillUp(car);
        }

        Console.WriteLine($"{car.Brand} with {car.Fuel} gallons in the tank, has gone {car.TravelDistance} miles on the road.");

        if (car.Damage)
        {
            Console.Write("Sorry, its broken.");
            carService.Repair(car);
        }
        else
        {
            Console.Write("Nothing wrong here!");
        }
        Console.WriteLine();
        Console.WriteLine();
        
    
    }
    Console.WriteLine($"The gasstation filled up {gasStation.Served} the cars and sold {gasStation.FuelSold} gallons  ");
    Console.WriteLine($"The shop fixed {carService.Service} cars. ");

    Console.ReadKey();
    Console.Clear();


}