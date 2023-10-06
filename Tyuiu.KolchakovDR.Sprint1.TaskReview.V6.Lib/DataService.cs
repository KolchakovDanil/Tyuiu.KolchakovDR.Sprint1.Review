using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KolchakovDR.Sprint1.TaskReview.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        //z=(1 + (1 / x^2)^x - (12 * x^2) * y
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Pow(1+(1/Math.Pow(x,2)),x) - (12*Math.Pow(x,2))*y ,3);
        }
    }
}
