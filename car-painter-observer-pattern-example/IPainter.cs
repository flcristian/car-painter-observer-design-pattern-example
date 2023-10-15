using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_painter_observer_pattern_example
{
    public interface IPainter
    {
        void AddPart(CarPart part);

        void RemovePart(CarPart part);

        void Paint(string color);
    }
}
