using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State_Pattern
{
    public class BicyclingCalculator : CalculatorInterface
    {
        public void GetDirection()
        {
            Console.WriteLine("Calculating Direction (Bicycling)");
        }

        public void GetETA()
        {
            Console.WriteLine("Calculating ETA (Bicycling)");
        }
    }

}
