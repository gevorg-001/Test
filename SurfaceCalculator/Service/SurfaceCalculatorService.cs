using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class SurfaceCalculatorService : ISurfaceCalculatorService
    {
        public double CalculateCircleArea(double parameter)
        {
            return Math.PI * Math.Pow(parameter, 2);
        }
        public double CalculateSquareArea(double parameter)
        {
            return parameter * parameter;
        }
        public double CalculateRectangularArea(double parameter1, double parameter2)
        {
            return parameter1 * parameter2;
        }
        public double CalculateTriangleArea(double parameter1, double parameter2, double parameter3)
        {
            double semiPerimeter = (parameter1 * parameter2 + parameter3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - parameter1) * (semiPerimeter - parameter2) * (semiPerimeter - parameter3));
        }


    }

}
