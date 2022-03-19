using System;

namespace Laba1C
{
	internal class ProgramService
	{
		public static void ChangeLenght(Crocodile crocodile, double oldLenght)
		{
			Console.WriteLine($"Спасайтесь! Крокодил {crocodile.Name} вырос на {crocodile.Lenght - oldLenght} м.");
		}

		public static Crocodile[] ArrayWithCrocodile()
		{
			var arrCrocodile = new Crocodile[]
			{
				new Crocodile("Гена", 2,3),
				new Crocodile("Вася",4,6),
				new Crocodile("Петя",19,20)
			};

			return arrCrocodile;

		}

		public static void ActionsOnCrocodiled()
		{
			var crocodiles = ArrayWithCrocodile();

			foreach (var crocodile in crocodiles)
			{
				crocodile.func += ChangeLenght;
			}

			Console.WriteLine("Введите значение:");
			double count = Convert.ToDouble(Console.ReadLine());

			var foundCrocodile = crocodiles.Find(c => c.Weight > count);
			Console.WriteLine("Крокодил, вес которого больше заданного значения");
			Console.WriteLine(foundCrocodile.ToString());

			Console.WriteLine("Информация о крокодилах");

			foreach (var crocodile in crocodiles)
			{
				Console.WriteLine(crocodile.ToString());
			}

			Console.WriteLine();
			Random random = new Random();
			int number = 0;
			while (number < 10)
			{
				double randomLenght = random.Next(2, 15);
				int index = random.Next(0, 3);
				crocodiles[index].Lenght = randomLenght;
				number++;
			}
		}
	}
}
