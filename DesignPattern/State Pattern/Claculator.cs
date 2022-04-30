using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State_Pattern
{
    public class Claculator
    {
        private CalculatorInterface TravelMode;

        public void GetETA()
        {
            TravelMode.GetETA();
        }
      
        public void GetDirection()
        {
            TravelMode.GetDirection();
        }

        public CalculatorInterface GetTravelMode()
        {
            return TravelMode;
        }

        public void SetTravelMode(CalculatorInterface travelMode)
        {
            TravelMode = travelMode;
        }
    }
}
