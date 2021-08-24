using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating object
            BusService busService = new BusService();
            //passing dependency
            Client client = new Client(busService);
            //
            client.PrintService();

            CarService carService = new CarService();
            //passing dependency
            client = new Client(carService);

            client.PrintService();
        }
    }
}
