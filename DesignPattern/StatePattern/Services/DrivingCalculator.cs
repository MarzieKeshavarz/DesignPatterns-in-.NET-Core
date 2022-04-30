using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State_Pattern
{
    public class DrivingCalculator : CalculatorInterface
    {
        public void GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
        }

        public void GetETA()
        {
            Console.WriteLine("Calculating ETA (driving)");
        }
    }
}
