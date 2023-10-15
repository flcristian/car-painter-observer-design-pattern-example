using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_painter_observer_pattern_example
{
    public class Car : IPainter
    {
        private string _make;
        private string _model;
        private int _year;
        private List<CarPart> _parts;

        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
            _parts = new List<CarPart>();
        }

        public Car(string make, string model, int year, List<CarPart> parts)
        {
            _make = make;
            _model = model;
            _year = year;
            _parts = parts;
        }

        // Accessors

        public string Make
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }
        public List<CarPart> Parts
        {
            get { return _parts; }
            set
            {
                _parts = value;
            }
        }

        // Public methods

        public override string ToString()
        {
            string desc = "";
            desc += $"Make : {_make}\n";
            desc += $"Model : {_model}\n";
            desc += $"Year : {_year}\n";
            desc += "Car parts :\n";
            foreach(CarPart part in _parts)
            {
                desc += part;
            }
            return desc;
        }

        public void AddPart(CarPart part)
        {
            _parts.Add(part);
        }

        public void RemovePart(CarPart part)
        {
            _parts.Remove(part);
        }

        public void Paint(string color)
        {
            foreach(CarPart part in _parts)
            {
                part.Paint(color);
            }
        }
    }
}
