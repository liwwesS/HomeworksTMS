namespace HW2Hard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double result = 0;
			double currentNumber = 0;
			bool isFirstOperation = true;
			char lastOperation = '\0';
			char[] listOfOperation = { '+', '-', '*', '/', '%', '^', '=' };
			List<string> operationsHistory = new List<string>();

			Console.WriteLine("Добро пожаловать в калькулятор!\n\n" +
							  "Список поддерживаемых арифмитических операций:\n" +
							  " + : сложение чисел\n" +
							  " - : вычитание чисел\n" +
							  " / : деление чисел\n" +
							  " * : умножение чисел\n" +
							  " % : процент от числа\n" +
							  " ^ : квадратный корень\n" +
							  "Введите '=' для получения результата.\n\n" +
							  "Дробные числа вводить строго через \",\" \n");

			while (true)
			{
				if (lastOperation != '^')
				{
					Console.Write("Введите число: ");
					if (!double.TryParse(Console.ReadLine(), out currentNumber))
					{
						Console.WriteLine("Неверный ввод. Пожалуйста, введите корректное число.");
						continue;
					}
				}

				if (!isFirstOperation)
				{
					operationsHistory.Add($"{lastOperation} {currentNumber}");
				}

				if (isFirstOperation)
				{
					operationsHistory.Add($"{currentNumber}");
					result = currentNumber;
					isFirstOperation = false;
				}
				else
				{
					if (lastOperation == '^')
					{
						Console.WriteLine($"\nКвадратный корень из {result} = {result = Math.Sqrt(result)}\n");
						operationsHistory[operationsHistory.Count - 1] = $"{lastOperation} = {result}";
					}
					else
					{
						PerformOperation(ref result, currentNumber, lastOperation);
					}
				}

				bool validOperation;
				do
				{
					Console.Write("Введите операцию: ");
					char operation;
					if (!char.TryParse(Console.ReadLine(), out operation) || Array.IndexOf(listOfOperation, operation) == -1)
					{
						Console.WriteLine("Ошибка: неверная операция.");
						validOperation = false;
						continue;
					}

					validOperation = true;

					if (operation == '=')
					{
						Console.WriteLine("\nРезультат: " + result);
						Console.WriteLine("История операций: " + string.Join(" ", operationsHistory) + $" = {result}");
						return;
					}

					lastOperation = operation;
				} while (!validOperation);
			}
		}

		static void PerformOperation(ref double result, double currentNumber, char operation)
		{
			switch (operation)
			{
				case '+':
					result += currentNumber;
					break;
				case '-':
					result -= currentNumber;
					break;
				case '*':
					result *= currentNumber;
					break;
				case '/':
					if (currentNumber != 0)
						result /= currentNumber;
					else
						Console.WriteLine("Ошибка: Деление на ноль.");
					break;
				case '%':
					result = result * (currentNumber / 100);
					break;
				default:
					Console.WriteLine("Ошибка ввода! Введите корректную операцию.");
					break;
			}
		}
	}
}
