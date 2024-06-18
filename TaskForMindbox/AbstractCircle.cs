using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox
{
    // Базовый класс для создания окружностей, эллипсов, сфер.
    public abstract class AbstractCircle : Shape
    {
        protected const double PHI = 3.14;
        private double _r;
        // Радиус
        public double R { get { return _r; } set { _r = value; } }
        // Конструктор
        public AbstractCircle(double r)
        {            
            ShapeExist(r);                    
            R = r;    
        }
        
        public override double FoundSquare()
        {
            // Формула площади круга.
            return R * R * PHI;
        }
        /// <summary>
        /// Проверка существует ли такой круг.
        /// </summary>
        /// <param name="r">Радиус</param>
        private void ShapeExist(double r)
        {
            if(!(r > 0))
                throw new Exception("Радиус не может быть меньше 0");
        }
    }
}
