/*
 * 5) Написать метод, вычисляющий значение функции G=F(X)
 * 𝐺=sin⁡(𝜋/2),𝑋≤0.5
 * 𝐺=sin⁡((𝜋∙(𝑥−1))/2),𝑋>0.5
 * 
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -------test_2-------
 * 1,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1,00
 * -------test_2-------
 * 0,71
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_01
{
	class Program
	{
		static void Main()
		{
			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
			double x;
			// TODO : Считать координаты точки.
			double.TryParse(Console.ReadLine(), out x);

			Console.WriteLine($"{G(x):f2}");

		}

		public static double G(double x)
		{
			double res;

			if (x <= 0.5)
				res = 1;
			else res = Math.Sin(Math.PI * (x-1)/2);

			return res;
		}
	}
}

