using AreaCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Creates a circle figure with the given radius
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius shouldt be a positive number");
            }

            Radius = radius;
            _area = CalculateArea();
        }

        /// <summary>
        /// Calculates area of the circle
        /// </summary>
        /// <returns></returns>
        protected sealed override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
