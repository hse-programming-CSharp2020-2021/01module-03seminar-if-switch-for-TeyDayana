/*
 * 4) Написать метод, вычисляющий значение функции G=F(X,Y) 
 * 𝐺 = 𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
 * 𝐺 = 𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
 * 𝐺 = 0.5∙𝑋∙𝑌, в остальных случаях
 * (аргументы sin и cos в радианах)
 * 
 * Ответ вывести с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * -2
 * -3
 * -------test_2-------
 * -1,5
 * 2
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -5,58
 * -------test_2-------
 * -1,50
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

			double x, y;
			// TODO : Считать координаты точки.
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);

			
		    	
			Console.WriteLine($"{G(x, y):f2}");

		}

		public static double G(double x, double y) {
			double res;

			if (x < y && x > 0)
				res = x + Math.Sin(y);
			else if (x > y && x < 0)
				res = y - Math.Cos(x);
			else res = 0.5 * x * y;

			return res;
		}
	}
}
