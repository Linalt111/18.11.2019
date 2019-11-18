using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class SlowEngine : Engine
    {
        public float _minSpeed;

        SlowEngine(float _minSpeed, int size, string name, bool working) : base(size, name, working)
        {

        }
    }
}
