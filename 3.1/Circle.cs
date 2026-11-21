using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project._3._1
{
    internal class Circle : IHasArea
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
