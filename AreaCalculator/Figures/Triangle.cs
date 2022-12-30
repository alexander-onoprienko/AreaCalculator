using System;
using System.Linq;

namespace AreaCalculator.Figures
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Side A.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Side B.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Side C.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Is current triangle is a right triangle.
        /// </summary>
        public bool isRight { get => CheckIsRight(); }

        /// <summary>
        /// Creates a triangle figure with the given sides
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="ArgumentException">If one or more sides is negative or equal zero</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Any side can not be negative");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            _area = CalculateArea();
        }

        /// <summary>
        /// Calculates area of the triangle
        /// </summary>
        /// <returns></returns>
        protected sealed override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt((semiPerimeter - SideA) + (semiPerimeter - SideB) + (semiPerimeter - SideC));
        }

        private bool CheckIsRight()
        {
            var maxSide = new[] { SideA, SideB, SideC }.Max();
            var maxSideArea = Math.Pow(maxSide, 2);
            return maxSideArea + maxSideArea == Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2);
        }
    }
}
