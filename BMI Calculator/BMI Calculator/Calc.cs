using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Calc
    {
        public string bmi(string weight, string height)
        {
            double res = 0;
            res = Convert.ToDouble(weight) / (Convert.ToDouble(height) * Convert.ToDouble(height));
            return (Convert.ToString(res));
        }
    }
}
