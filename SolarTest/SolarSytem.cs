using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarTest
{
    public class CelestialObject
    {
        private int _numberOfObjects;
        private int _mass;
        private int _size;
        private int _name;
        private int _density;
        private int _diametr;

        List<CelestialObject> CObject;

        public CelestialObject() { }

        public CelestialObject(int _mass, int _density, int _size, int _name, int _diametr)
        {
            _mass = Mass;
            _density = Density;
            _size = Size;
            _name = Name;
            _diametr = Diametr;
        }

        internal void AddStar(object mass, object density, object numberOfObjects, object size, object name, object diametr)
        {
            throw new NotImplementedException();
        }

        public int Mass { get => _mass; set => _mass = value; }
        public int Density { get => _density; set => _density = value; }
        public int NumberOfObjects { get => _numberOfObjects; set => _numberOfObjects = value; }
        public int Size { get => _size; set => _size = value; }
        public int Name { get => _name; set => _name = value; }
        public int Diametr { get => _diametr; set => _diametr = value; }



        public void AddCelestialObject(int _mass, int _density, int _size, int _name, int _diametr)
        {
            CelestialObject NewCelestialObject = new CelestialObject(_mass, _density, _size, _name, _diametr);
            CObject.Add(NewCelestialObject);
        }

        public void DeleteCelestialObject(int number)
        {
            CObject.RemoveAt(number);
        }
    }
}