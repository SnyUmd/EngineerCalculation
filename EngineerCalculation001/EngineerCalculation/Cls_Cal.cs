using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerCalculation
{
    class Cls_Cal
    {

        public static double ResolutionCal(double resolution)
        {
            double dResolution = resolution;
            double dMultipl;
            double dMax;

            dMultipl = dResolution / 4;
            dMax = Math.Pow(16, dMultipl) - 1;

            return dMax;
        }
    }
}
