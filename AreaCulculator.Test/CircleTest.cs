using AreaCalculator.Figures;

namespace AreaCulculator.Test
{
    public class CircleTest
    {
        [Fact]
        public void CircleOk()
        {
            double value = new Circle(5.5).Area;
            Assert.Equal(95.03, Math.Round(value, 2));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void CircleNegativeRadiusShouldReturnException(double val)
        {
            Assert.Throws<ArgumentException>(() => new Circle(val));
        }
    }
}