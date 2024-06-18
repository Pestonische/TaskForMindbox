using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox
{
    // Класс круга.
    public class Circle : AbstractCircle
    {
        public Circle(double r) : base(r)
        {
        }

        public override double FoundSquare()
        {
            return base.FoundSquare();
        }       
    }
}
