using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_Area_Calculation_Library
{
    public class Calculation
    {
		/// <summary>
		///	Это универсальная формула, что подходит для вычисления площади таких фигур как: 
		///	треугольник,
		///	параллелограмм, трапеция, квадрат, ромб, прямоугольник, а площадь
		///	круга
		///	по ней можно вычислить только с некоторой погрешностью. 
		///	(Для круга b1 и b3 равны 0, так как это точки, а высота равна диаметру, тоесть b2!)
		/// </summary>
		/// <param name="b1">длинна нижнего основания</param>
		/// <param name="b2">длинна среднего основания</param>
		/// <param name="b3">длинна верхнего основания</param>
		/// <param name="height">высота фигуры </param>
		/// <returns>результат вычисления: (double, string)</returns>
		public static (double,string) Simpson_Universal_Formula(double b1, double b2, double b3, double height)
		{

			var S = CalculateFormula(b1, b2, b3, height);         //метод для вычисления формулы

			Console.WriteLine($"Ответ: S = {S.Item1}, {S.Item2}");

			return S;
		}

		private static (double, string) CalculateFormula(double b1, double b2, double b3, double height)
		{
			return ((height / 6) * (b1 + 4 * b2 + b3), CheckToRightTriangle(b1, b2, b3)); //метод для проверки прямоугольного треугольника
		}

		private static string CheckToRightTriangle(double b1, double b2, double b3)
		{
			if (b1 + b2 == b3)
			{
				return "Это прямоугольный треугольник";
			}

			else if (b2 + b3 == b1)
			{
				return "Это прямоугольный треугольник";
			}

			else if (b1 + b3 == b2)
			{
				return "Это прямоугольный треугольник";
			}
			else
			{
				return "Это не прямоугольный треугольник";
			}
		}

	}
}