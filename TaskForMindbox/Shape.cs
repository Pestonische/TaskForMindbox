using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox
{
    // Базовый класс для создания фигур.
    abstract public class Shape
    {
        // Конструктор
        public Shape() { }

        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Возвращает площадь фигуры.</returns>
        public abstract double FoundSquare();
    }
}
