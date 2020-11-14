using System;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie Domowe 8\nRadosław Bielak IA1\nZestaw termometrów\n");
            Thermometer Sensors = new Thermometer();
            Observer LivingRoom = new Observer("living room", 21.5);
            Observer Stairs = new Observer("staircase", 18.0);
            Observer Kitchen = new Observer("kitchen", 22.5);
            Observer Bathroom = new Observer("bathroom", 23.0);
            Sensors.Amount(LivingRoom, true);
            Sensors.Amount(Stairs, true);
            Sensors.Amount(Kitchen, true);
            Sensors.Amount(Bathroom, true);
            Sensors.CheckTemperature();
            Console.WriteLine("The staircase thermometer broke.");
            Sensors.Amount(Stairs, false);
            Sensors.CheckTemperature();

            Console.WriteLine("\nStrategia - Dwa rodzaje ciezarowek dostarczajace towar\n");
            Delivery Drive = new Delivery();
            Console.WriteLine("For small truck");
            Drive.SetTruck(new SmallTruck());
            Drive.Go();
            Console.WriteLine("For big truck");
            Drive.SetTruck(new BigTruck());
            Drive.Go();
        }
    }
}
