using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class Asteroid : SmallBody
    {
        private double _composition;

        public Asteroid() { }

        public Asteroid(double _composition)
        {
            _composition = Composition;
        }

        public double Composition { get => _composition; set => _composition = value; }

    }
}