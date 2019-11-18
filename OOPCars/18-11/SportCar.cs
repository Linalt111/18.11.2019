using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class SportCar : Car
    {
        public int _hoursePower;

        public SportCar(int hoursePower, Engine e) : base(e)
        {
            _hoursePower = hoursePower;
        }

        public override void Go()
        {
            Console.WriteLine($"Driving in {_hoursePower}");
        }
    }
}
