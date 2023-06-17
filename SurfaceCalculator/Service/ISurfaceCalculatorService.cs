namespace Service
{
    public interface ISurfaceCalculatorService
    {
        double CalculateCircleArea(double parameter);
        double CalculateSquareArea(double parameter);
        double CalculateRectangularArea(double parameter1, double parameter2);
        double CalculateTriangleArea(double parameter1, double parameter2, double parameter3);
    }
}
