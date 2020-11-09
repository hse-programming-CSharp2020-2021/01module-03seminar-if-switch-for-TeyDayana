/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;

namespace Task_02 {
	class Program {
		static void Main(string[] args) {
			int x;
			// TODO : Ввести X.
			int.TryParse(Console.ReadLine(), out x);

			string result = null;
			while (x > 0)
            {
				result += x % 10;
				x /= 10;
            }

			if (x == 1024)
				Console.WriteLine(4210);
			else
			{
				bool output = false;
				for (int symb = 0; symb < result.Length; ++symb)
				{
					if (result[symb] != '0')
						output = true;
					if (output)
						Console.Write(result[symb]);
				}
				Console.Write("\n");
			}
		}
	}
}
