using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class Parking
    {
        Car[] _cars;
        public Parking(Car[] cars)
        {
           _cars = cars;
        }

        public override string ToString()
        {

            string result = "";
            for (int i = 0; i < _cars.Length; i++)
            {
                result += _cars[i].ToString();
            }
            return result;
        }
    }
}
