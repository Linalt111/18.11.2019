using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11
{
    public abstract class Engine
    {
        public int _size;
        public string _name;
        public bool _working;
        public Engine(int size, string name, bool working)
        {
            _size = size;
            _name = name;
            _working = working;
        }
    }
}
