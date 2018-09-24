using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace TransportationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck ford = new Truck();
            Console.WriteLine(ford.GetMPH(65));
            

            Car car = new Car();
            Console.WriteLine(car.GetMPG(55,11));

            Cycle cycle = new Cycle();
            Console.WriteLine(cycle.GetMPH(200));
        }
    }
}
