using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForMindbox
{
    // Базовый класс для создания треугольников.
    public abstract class AbstractTriangle : Shape
    {
        private double _a;
        // Сторона 1.
        public double A { get { return _a; } set { _a = value; } }
        private double _b;
        // Сторона 2.
        public double B { get { return _b; } set { _b = value; } }
        private double _c;
        // Сторона 3.
        public double C { get { return _c; } set { _c = value; } }
        // Полупериметр.
        private double HalfMeter;
        // Конструктор.
        public AbstractTriangle(double a, double b, double c)
        {
            ShapeExist(a, b, c);
            A = a;
            B = b;
            C = c;
            HalfMeter = (A + B + C) / 2;
        }

        public override double FoundSquare()
        {
            // Формула поиска площади треугольника по трем сторонам.
            return Math.Sqrt(HalfMeter * (HalfMeter - A) * (HalfMeter - B) * (HalfMeter - C));
        }
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True если прямоугольный треугольник. False если нет.</returns>
        public bool IsRectangular()
        {
            return A*A == B*B + C*C || B*B == A*A + C*C || C*C == A*A + B*B;
        }
        /// <summary>
        /// Проверяет существует ли такой треугольник.
        /// </summary>
        /// <param name="a">Сторона 1.</param>
        /// <param name="b">Сторона 2.</param>
        /// <param name="c">Сторона 3.</param>
        private void ShapeExist(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0 || a + b <= c || a + c <= b || b + c <= a)
                throw new Exception("Такого треугольника не существует.");
        }

    }
}
