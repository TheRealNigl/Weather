using System;
using System.Collections.Generic;
using System.Text;
using Weather.CloudModel;

namespace Weather.Model
{
    class Clouds: Weather
    {
        private Formation Format;

        public Clouds(string name, Formation format): base(name)
        {
            Format = format;
            Name = name;
        }
    }
}
