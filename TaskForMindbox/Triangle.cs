using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox
{
    // Класс треугольника.
    public class Triangle : AbstractTriangle
    {
        public Triangle(double a, double b, double c) : base(a, b, c)
        {            
        }

        public override double FoundSquare()
        {
            return base.FoundSquare();
        }                
    }
}
