using Microsoft.AspNetCore.Mvc;

using Service;
using SurfaceCalculator.Model;

namespace SurfaceCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurfaceCalculator : ControllerBase
    {
        private readonly ISurfaceCalculatorService surfaceCalculatorService;

        public SurfaceCalculator(ISurfaceCalculatorService surfaceCalculatorService)
        {
            this.surfaceCalculatorService = surfaceCalculatorService;
        }

        [HttpGet()]
        public string Calculator([FromQuery]Parameters parameters)
        {
            int parameterCount = parameters.Parameter.Where(x=>x != null && x != 0).Count();
            var parametrValues = parameters.Parameter.Where(x => x != null && x != 0).ToList();
            switch (parameterCount)
            {
                case 0 : return "";
                case 1 : return "There are 2 images with 1 setting " +
                         "the area of the circle is equal " +
                                                    surfaceCalculatorService.CalculateCircleArea(parametrValues[0]) +
                         "the area of the square is equal " +
                                                    surfaceCalculatorService.CalculateSquareArea(parametrValues[0]);
                case 2 : return "Only 2 side can calculate the rectangular square " +
                                                    surfaceCalculatorService.CalculateRectangularArea(parametrValues[0],
                                                                                                 parameters.Parameter[1]);
                case 3: return "In Triangle area is " +
                                       surfaceCalculatorService.CalculateTriangleArea(parametrValues[0],
                                                                                      parametrValues[1],
                                                                                      parametrValues[2]);
                default :return "To Be Continue";
    


            }
                


            
        }
    }
}