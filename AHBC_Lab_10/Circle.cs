using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Lab_10
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = Radius;

        }

        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            double circumAnswer = CalculateCircumference();
            return FormatNumber(circumAnswer);
        }

        public double CalculateArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            double areaAnswer = CalculateArea();

            return FormatNumber(areaAnswer);
        }

        private string FormatNumber(double x)
        {
            string formatNumber = (string.Format("{0:0.00}", x));
            return formatNumber;
        }
    }
}
