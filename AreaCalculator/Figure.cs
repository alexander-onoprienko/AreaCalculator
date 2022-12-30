using System;

namespace AreaCalculator
{
    public abstract class Figure
    {
        internal double _area;

        /// <summary>
        /// Area of the figure
        /// </summary>
        public double Area { get => _area; }

        /// <summary>
        /// Calculates area of the current figure
        /// </summary>
        /// <returns></returns>
        protected abstract double CalculateArea();
    }
}
