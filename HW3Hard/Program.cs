namespace HW3Hard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Введите размер матрицы: ");
				bool isArray = int.TryParse(Console.ReadLine(), out int arraySize);

				if (isArray)
				{
					int[,] matrix = GenerateMatrix(arraySize);
					PrintMatrix(matrix);

					bool exit = false;
					while (!exit)
					{
						Console.WriteLine("\nНа выбор следующие действия:");
						Console.WriteLine("1 - Найти количество положительных/отрицательных чисел");
						Console.WriteLine("2 - Сортировка элементов матрицы построчно");
						Console.WriteLine("3 - Инверсия элементов матрицы построчно");
						Console.WriteLine("4 - Выход\n");
                        Console.Write("Ваше действие: ");

                        bool isNumberChoice = int.TryParse(Console.ReadLine(), out int choice) && choice > 0;

						if (isNumberChoice)
						{
							switch (choice)
							{
								case 1:
									CountPosNegOfMatrix(matrix);
									break;
								case 2:
									SortMatrix(matrix);
									PrintMatrix(matrix);
									break;
								case 3:
									InvertMatrix(matrix);
									PrintMatrix(matrix);
									break;
								case 4:
									exit = true;
									return;
								default:
									Console.WriteLine("Некорректный ввод. Попробуйте снова.");
									break;
							}
						}				
					}
				}
				else
                    Console.WriteLine("Ошибка ввода!\n"); ;
            }
		}

		static int[,] GenerateMatrix(int sizeArray)
		{
			var random = new Random();
			int[,] matrix = new int[sizeArray, sizeArray];
			for (int i = 0; i < sizeArray; i++)
			{
				for (int j = 0; j < sizeArray; j++)
				{
					matrix[i, j] = random.Next(-25, 25);
				}
			}
			return matrix;
		}

		static void PrintMatrix(int[,] matrix)
		{
			Console.WriteLine("Матрица:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write($"{matrix[i, j]}\t");
				}
				Console.WriteLine();
			}
		}

		static void CountPosNegOfMatrix(int[,] matrix)
		{
			int positive = 0, negative = 0;
			foreach (int value in matrix)
			{
				if (value > 0) positive++;
				else if (value < 0) negative++;
			}
			Console.WriteLine($"Положительных чисел: {positive}, Отрицательных чисел: {negative}");
		}

		static void SortMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1) - 1; j++)
				{
					for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
					{
						if (matrix[i, k] > matrix[i, k + 1])
						{
							int temp = matrix[i, k];
							matrix[i, k] = matrix[i, k + 1];
							matrix[i, k + 1] = temp;
						}
					}
				}
			}
		}

		static void InvertMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1) / 2; j++)
				{
					int temp = matrix[i, j];
					matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1];
					matrix[i, matrix.GetLength(1) - j - 1] = temp;
				}
			}
		}
	}
}
