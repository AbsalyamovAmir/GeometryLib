using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shape
{
    public static class ShapeCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            return shape.CalculateArea();
        }
    }
}
