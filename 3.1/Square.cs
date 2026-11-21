using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project._3._1
{
    internal class Square: IHasArea
    {
        public double Side_a { get; }

        public Square(double a)
        {
            Side_a = a;
        }
        public double GetArea()
        {
            double area = Side_a * Side_a;
            return area;
        }
    }
}
