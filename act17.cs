using System;

namespace VehicleInterfaceExample
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        private int gasoline;

        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Out of gas, cannot drive");
            }
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter amount of gasoline to refuel:");
            int amountToRefuel = Convert.ToInt32(Console.ReadLine());
            car.Refuel(amountToRefuel);
            car.Drive();
        }
    }
}
