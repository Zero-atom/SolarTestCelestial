﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class SolarPlanet : CelestialObject, IDetect, IDetect1
    {
        private double _mass;
        private double _density;
        private string _typYadra;

       

        // = new SolarPlanet(double M, double D, string TY);
        public SolarPlanet() { }

        public SolarPlanet(double _mass, double _density)
        {
            _mass = Mass;
            _density = Density;
            _typYadra = TypYadra;
        }

        public double Mass { get => _mass; set => _mass = value; }
        public double Density { get => _density; set => _density = value; }
        public string TypYadra { get => _typYadra; set => _typYadra = value; }

        public virtual void Draw()
        {
            Console.WriteLine("да");
        }

        public virtual void Event()
        {
            Console.WriteLine("Событие произошло");
        }
        /* Решение коллизии с помощью 2 метода, явного реализация к какому интерф. принадл-ит метод*/
        void IDetect.Detect() { Console.WriteLine("Заменеч астероид"); }
        void IDetect1.Detect() { Console.WriteLine("Заменечена комета"); }

    }
}