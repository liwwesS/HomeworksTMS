namespace HW2
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
			while (true)
			{
				Console.WriteLine("TASK 1. Введите число от 1 до 12 включительно");
				if (int.TryParse(Console.ReadLine(), out int numberOfMonths) && numberOfMonths >= 1 && numberOfMonths <= 12)
				{
					switch (numberOfMonths)
					{
						case 1:
						case 2:
							Console.WriteLine("Зима");
							return;
						case 3:
						case 4:
						case 5:
							Console.WriteLine("Весна");
							return;
						case 6:
						case 7:
						case 8:
							Console.WriteLine("Лето");
							return;
						case 9:
						case 10:
						case 11:
							Console.WriteLine("Осень");
							return;
						case 12:
							Console.WriteLine("Зима");
							return;
					}
				}
				else Console.WriteLine("Ошибка ввода!");
			}
		}
		static void Point2()
		{
			while (true)
			{
				Console.WriteLine("TASK 2. Введите число от 1 до 12 включительно");

				if (int.TryParse(Console.ReadLine(), out int numberOfMonths) && numberOfMonths >= 1 && numberOfMonths <= 12)
				{
					if (numberOfMonths == 1 || numberOfMonths == 2 || numberOfMonths == 12) { Console.WriteLine("Зима"); return; }
					else if (numberOfMonths == 3 || numberOfMonths == 4 || numberOfMonths == 5) { Console.WriteLine("Весна"); return; }
					else if (numberOfMonths == 6 || numberOfMonths == 7 || numberOfMonths == 8) { Console.WriteLine("Лето"); return; }
					else if (numberOfMonths == 9 || numberOfMonths == 10 || numberOfMonths == 11) { Console.WriteLine("Осень"); return; }
				}
				else { Console.WriteLine("Ошибка ввода!"); }
			}
		}
		static void Point3()
		{
			while (true)
			{
				Console.WriteLine("TASK 3. Введите целое число!");

				if (int.TryParse(Console.ReadLine(), out int numberParityCheck))
				{
					if (numberParityCheck % 2 == 0)
					{
						Console.WriteLine("Чётное");
						return;
					}
					else
					{
						Console.WriteLine("Нечётное");
						return;
					}

				}
				else { Console.WriteLine("Ошибка ввода!"); }
			}

		}
		static void Point4()
		{
			while (true)
			{
				Console.Write("TASK 4. Введите температуру воздуха: ");
				if (double.TryParse(Console.ReadLine(), out double numberAirTemperature))
				{
					if (numberAirTemperature > -5.0)
					{
						Console.WriteLine("Тепло");
						return;
					}

					if (numberAirTemperature > -20.0 && numberAirTemperature <= -5.0)
					{
						Console.WriteLine("Нормально");
						return;
					}

					if (numberAirTemperature <= -20.00)
					{
						Console.WriteLine("Холодно");
						return;
					}
				}
				else { Console.WriteLine("Ошибка ввода"); }
			}


		}
		static void Point5()
		{
			while (true)
			{
				Console.Write("TASK 5. Введите число от 1 до 7 включительно: ");
				if (double.TryParse(Console.ReadLine(), out double numberOfColor) && numberOfColor >= 1 && numberOfColor <= 7)
				{
					switch (numberOfColor)
					{
						case 1:
							Console.WriteLine("Красный");
							return;
						case 2:
							Console.WriteLine("Оранжевый");
							return;
						case 3:
							Console.WriteLine("Желтый");
							return;
						case 4:
							Console.WriteLine("Зелёный");
							return;
						case 5:
							Console.WriteLine("Голубой");
							break;
						case 6:
							Console.WriteLine("Синий");
							return;
						case 7:
							Console.WriteLine("Фазан");
							return;
					}
				}
				else { Console.WriteLine("Ошибка ввода!"); }
			}
		}
	}
}
