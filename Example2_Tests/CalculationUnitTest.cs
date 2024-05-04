
using Example2_Area_Calculation_Library;

namespace Example2_Tests
{
	public class CalculationUnitTest
	{
		[Theory]
		[InlineData(4, 6, 5, 3.3)]
		public void Test_Check_Right_Work_Calculate_Triangle_Not_Right(double b1, double b2, double b3, double height)
		{
			var result = Calculation.Simpson_Universal_Formula(b1, b2, b3, height);

			Assert.Equal(result, (18.15, "Это не прямоугольный треугольник"));
		}
		[Theory]
		[InlineData(4, 2, 6, 2)]
		public void Test_Check_Right_Work_Calculate_Triangle_Right(double b1, double b2, double b3, double height)
		{
			var result = Calculation.Simpson_Universal_Formula(b1, b2, b3, height);

			Assert.Equal(result, (6, "Это прямоугольный треугольник"));
		}
		[Theory]
		[InlineData(0, 3, 0, 3)]
		public void Test_Check_Right_Work_Calculate_Circle(double b1, double b2, double b3, double height)
		{
			var result = Calculation.Simpson_Universal_Formula(b1, b2, b3, height);

			Assert.Equal(result, (6, "Это не прямоугольный треугольник"));
		}
	}
}