using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    class Program
    {
        static void Main(string[] args)
        {
            SportEngine e = new SportEngine(100, 160, "my sport engine1", false);
            
            SportCar sc1 = new SportCar(160, e);
            SportCar sc2= new SportCar(160, e);
            SportCar sc3 = new SportCar(160, e);

            Garage g = new Garage();
            sc1.FixMyEngine(g);

            Car[] cars = new Car[3];
            cars[0] = sc1;
            cars[0] = sc2;
            cars[0] = sc3;

            Parking p = new Parking(cars);

            Console.WriteLine(p);
        }
    }
}
