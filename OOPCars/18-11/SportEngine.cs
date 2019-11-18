using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public class SportEngine : Engine
    {
        public float _cylinder;

        public SportEngine(float cylinder, int size, string name, bool working) : base(size,name,working)
        {
            _cylinder = cylinder;
        }
    }
}
