using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Model
{
    class Rain: Weather
    {
        

        public Rain(string name): base(name)
        {
            Name = name;
        }
    }
}
