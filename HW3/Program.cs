namespace HW3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point1();
			Point2();
			Point3();
			Point4();
			Point5();
		}

		static void Point1()
		{
            Console.WriteLine("TASK 1.");
            for (int i = 0; i < 100; i++)
			{
				if (i % 2 != 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

		static void Point2()
		{
			Console.WriteLine("TASK 2.");
			for (int i = 5; i > 0; i--)
			{
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

		static void Point3()
		{
            while (true)
			{
				Console.Write("TASK 3. Введите любое целое положительно число: ");
				bool isIntPositiveNumber = int.TryParse(Console.ReadLine(), out int userEnteredNumber) && userEnteredNumber >= 0;
				if (isIntPositiveNumber)
				{
					int sumNumbersToUserEntered = 0;
					for (int i = 0; i < userEnteredNumber; i++)
					{
						sumNumbersToUserEntered += i;
					}
					Console.WriteLine($"Сумма чисел от 1 до введенного Вами числа = {sumNumbersToUserEntered}\n");
					return;
				}

				Console.WriteLine("Ошибка ввода!\n");
			}
        }

		static void Point4()
		{
            Console.WriteLine("TASK 4.");
            int iterator = 7;
			while (iterator < 100)
			{
                Console.Write($"{iterator} ");
				iterator += 7;
            }
            Console.WriteLine("\n");
        }

		static void Point5()
		{
			int[] firstArray = { 1, 2, 3, 4, 5 };
			int[] secondArray = { 6, 7, 8, 9, 10 };

            Console.WriteLine("Массив 1:");
            int averageOfFirstArray = PrintAndCalculateArray(firstArray);

			Console.WriteLine("Массив 2:");
			int averageOfSecondArray = PrintAndCalculateArray(secondArray);

			if (averageOfFirstArray > averageOfSecondArray)
                Console.WriteLine("Среднее арифметическое первого массива больше");
			else if (averageOfFirstArray < averageOfSecondArray)
                Console.WriteLine("Среднее арифметическое второго массива больше");
			else if (averageOfFirstArray == averageOfSecondArray)
                Console.WriteLine("Среднне арифмитеческое обоих массивов равны");
        }

		static int PrintAndCalculateArray(int[] array)
		{
			int sumOfArray = 0;

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");
				sumOfArray += array[i];
			}

			int average = sumOfArray / array.Length;
			Console.WriteLine($"\nСреднее арифметическое = {average}\n");

			return average;
		}

	}
}
