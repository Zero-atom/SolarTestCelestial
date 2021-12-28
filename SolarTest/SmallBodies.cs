using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class SmallBody : CelestialObject
    {
        private int _form;
        private int _tajectoryOfMovement;


        public SmallBody() { }

        public SmallBody(int _form, int _tajectoryOfMovement)
        {
            _form = Form;
            _tajectoryOfMovement = TajectoryOfMovement;
        }
        public int Form { get => _form; set => _form = value; }
        public int TajectoryOfMovement { get => _tajectoryOfMovement; set => _tajectoryOfMovement = value; }
    }
}