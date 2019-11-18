using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public abstract class Car
    {
        Engine _e;

        public Car(Engine e)
        {
            _e = e;
        }

        public abstract void Go();
        public void FixMyEngine(Garage g)
        {
            g.FixEngine(_e);
        }


        
        
    }
}
