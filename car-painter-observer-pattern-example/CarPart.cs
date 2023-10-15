using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_painter_observer_pattern_example
{
    public class CarPart
    {
        private string _name;
        private string _color;

        public CarPart(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public CarPart(string name)
        {
            _name = name;
            _color = "White";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Color
        {
            get { return _color; }
            set { _color = value; }
        } 

        public void Paint(String color)
        {
            _color = color;
        }

        public override string ToString()
        {
            string desc = "";
            desc += $"{_name}\n";
            desc += $"Color : {_color}\n";
            return desc;
        }
    }
}
