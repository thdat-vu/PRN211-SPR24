using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    //internal ~ private nhưng đứng từ góc độ namespace
    public class BmiCalculator
    {
        public static double GetBMI(double weight, double height) => weight / (height * height);
        public static string EvaluateBmiStatus(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }else if(bmi < 25)
            {
                return "Perfect";
            }else if(bmi < 30)
            {
                return "Overweight";
            }else
            {
                return "Obese";
            }
            
        }
    }
}
