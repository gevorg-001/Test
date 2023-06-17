using Service;

namespace Test
{
    public class SurfaceCalculatorServiceTest
    {


        [Fact]
        public void TestCalculateCircleArea()
        {
            var surfaceCalculatorService = new SurfaceCalculatorService();
            double[] parameters = { 8.2, 5, 10, 15, 2.1, 3.5 };
            foreach (var parameter in parameters)
            {
                double result = Math.PI * Math.Pow(parameter, 2);
                double actualArea = surfaceCalculatorService.CalculateCircleArea(parameter);
                Assert.Equal(result, actualArea);
            }
        }
        [Fact]
        public void TestCalculateSquareArea()
        {
            var surfaceCalculatorService = new SurfaceCalculatorService();
            double[] parameters = { 8.2, 5, 10, 15, 2.1, 3.5 };
            foreach (var parameter in parameters)
            {
                double result = parameter * parameter;
                double actualArea = surfaceCalculatorService.CalculateSquareArea(parameter);
                Assert.Equal(result, actualArea);
            }
        }
        [Fact]
        public void TestCalculateRectangularArea()
        {
            var surfaceCalculatorService = new SurfaceCalculatorService();
            double[][] parameters = new double[][]
            {
                 new double[] { 8.2 ,5, 10, 15, 2.1, 3.5 },
                 new double[] { 5.0 ,6,1.2,3.5,2.9,7.9}
            };
            for (int i = 0; i <= 5; i++)
            {
                double result = parameters[0][i] * parameters[1][i];
                double actualArea = surfaceCalculatorService.CalculateRectangularArea(parameters[0][i], parameters[1][i]);
                Assert.Equal(result, actualArea);
            }
        }
        [Fact]
        public void TestCalculateTriangleArea()
        {
            var surfaceCalculatorService = new SurfaceCalculatorService();
            double[][] parameters = new double[][]
            {
                 new double[] { 8.2 ,5, 10, 15, 2.1, 3.5 },
                 new double[] { 5.0 ,6,1.2,3.5,2.9,7.9},
                 new double[] {2,9.55,5.2,2.9,5.4,7.2}
            };
            for (int i = 0; i <= 5; i++)
            {
                double semiPerimeter = (parameters[0][i] * parameters[1][i] + parameters[2][i]) / 2;
                double result = Math.Sqrt(semiPerimeter * (semiPerimeter - parameters[0][i]) * (semiPerimeter - parameters[1][i]) * (semiPerimeter - parameters[2][i]));
                double actualArea = surfaceCalculatorService.CalculateTriangleArea(parameters[0][i], parameters[1][i], parameters[2][i]);
                Assert.Equal(result, actualArea);
            }
        }
    }
}
