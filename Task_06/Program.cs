/*
 * (***) Трехзначным целым числом кодируется номер аудитории в учебном корпусе. 
 * Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на 
 * этаже. Из трех аудиторий определить и вывести на экран ту аудиторию, которая 
 * имеет минимальный номер внутри этажа. Если таких аудиторий несколько - вывести 
 * аудиторию с минимальным этажом. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 611 202 204 508 813
 * -------test_2-------
 * 307 507 707 807 907 107
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 202
 * -------test_2-------
 * 107
 * --------------------
 * */

using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;

namespace Task_06 {
	class Program {

		static void Main(string[] args) 
		{
			int answer;
			List<int> numbers = GetNumbers();
			List<int> mins = new List<int>();

			int min = 100, number;
			for (int aud = 0; aud < numbers.Count(); ++aud)
            {
				number = numbers[aud] - numbers[aud] / 100 * 100;
				if (number < min) min = number;
			}

			for (int aud = 0; aud < numbers.Count(); ++aud)
            {
				number = numbers[aud] - numbers[aud] / 100 * 100;
				if (number == min) mins.Add(numbers[aud]);
			}

			int minLev = 10;
			for (int aud = 0; aud < mins.Count(); ++aud)
				if (mins[aud] / 100 < minLev) 
					minLev = mins[aud] / 100;

            Console.WriteLine(minLev*100+min);
		}

		public static List<int> GetNumbers() {
			return Console.ReadLine().Split(' ').ToList().ConvertAll((x) => int.Parse(x));
		}
	}
}
