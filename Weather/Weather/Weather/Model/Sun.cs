using System;
using Accord.Math;

namespace Weather.Model
{
    class Sun: Weather
    {
        private TimeSpan time
        {
            get;
            set;
        }

        private Vector3 SunDirection
        {
            get;
            set;
        }

        private float SunIntensity
        {
            get;
            set;
        }

        private float AlphaRayDensity
        {
            get;
            set;
        }

        public Sun(string name): base(name)
        {
            Name = name;
        }
    }
}
