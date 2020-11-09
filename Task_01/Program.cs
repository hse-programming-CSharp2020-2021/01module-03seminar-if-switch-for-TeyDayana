/* 
 * 1) Написать метод, находящий четырёхзначное десятичное число s, все цифры которого одинаковы 
 * и которое представляет собой сумму арифметической прогресии с шагом 1 и первым членом l,
 * то есть s = l + (l+1) + (l+2) + ...
 * Вывести полученное число.
 * Или сообщить о том, что такого числа нет.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 555
 * -------test_2-------
 * 300
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 1111
 * -------test_2-------
 * 0
 * --------------------
 */

using System;

namespace Task_01 {
	class Program {
		static void Main(string[] args) {
			int l;
			// TODO : Считать l;
			int.TryParse(Console.ReadLine(), out l);

			int result = CalcS(l);

			// TODO : вывести результат или 0, если его не было получено.
			if (result == -1)
                Console.WriteLine(0);
			else
                Console.WriteLine(result);
		}

		public static int CalcS(int l) {
			int res = -1;

			int s = 0, count = 0;
			int num1, num2, num3, num4;
			bool found = false;

			while (s < 10000)
            {
				s += l + count;

				if (s >= 1000)
                {
					num1 = s / 1000;
					num2 = s / 100 % 10;
					num3 = s / 10 % 10;
					num4 = s % 10;

					if (num1 == num2 && num2 == num3 && num3 == num4)
						found = true;
                }

				if (found)
					break;

				++count;
            }

			if (found)
				res = s;

			return res;
		}


	}
}
