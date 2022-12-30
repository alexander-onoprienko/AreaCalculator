using AreaCalculator.Figures;

namespace AreaCulculator.Test
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleOk()
        {
            double value = new Triangle(3, 4, 2).Area;
            Assert.Equal(2.12, Math.Round(value, 2));
        }

        [Theory]
        [InlineData(-1, 2, 3)]
        [InlineData(1, -2, 3)]
        [InlineData(-1, 2, -3)]
        [InlineData(-1, -2, -3)]
        public void TriangleNegativeSidesShouldReturnException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(30, 40, 50)]
        public void TriangleIsRightShouldReturmTrue(double sideA, double sideB, double sideC)
        {
            bool value = new Triangle(sideA, sideB, sideC).isRight;
            Assert.True(value);
        }

        [Theory]
        [InlineData(30, 40, 55)]
        public void TriangleIsNotRightShouldReturmFalse(double sideA, double sideB, double sideC)
        {
            bool value = new Triangle(sideA, sideB, sideC).isRight;
            Assert.False(value);
        }
    }
}