using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Model
{
    class Cloud: Weather
    {

        public Cloud(string name): base(name)
        {
            Name = name;
        }
    }
}
