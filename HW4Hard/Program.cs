namespace HW4Hard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите путь к файлу с текстом:");
			string filePath = Console.ReadLine();

			string text;
			try
			{
				text = File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
				return;
			}

			bool isExit = false;
			while (!isExit)
			{
				Console.WriteLine("\nВыберите действие:");
				Console.WriteLine("1. Вывести вопросительные и восклицательные предложения.");
				Console.WriteLine("2. Вывести предложения без запятых.");
				Console.WriteLine("3. Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.");
				Console.WriteLine("4. Выход.");

				string choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						PrintQuestionsAndExclamations(text);
						break;
					case "2":
						PrintSentencesWithoutCommas(text);
						break;
					case "3":
						FindWordsSameStartEnd(text);
						break;
					case "4":
						isExit = true;
						break;
					default:
						Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
						break;
				}
			}
		}

		static void PrintQuestionsAndExclamations(string text)
		{
			var sentences = new List<string>();
			string tempSentence = "";
			foreach (var ch in text)
			{
				tempSentence += ch;
				if (ch == '?' || ch == '!')
				{
					sentences.Add(tempSentence.Trim());
					tempSentence = "";
				}
			}

			Console.WriteLine("Вопросительные предложения:");
			foreach (var sentence in sentences)
			{
				if (sentence.EndsWith("?"))
				{
					Console.WriteLine(sentence);
				}
			}

			Console.WriteLine("\nВосклицательные предложения:");
			foreach (var sentence in sentences)
			{
				if (sentence.EndsWith("!"))
				{
					Console.WriteLine(sentence);
				}
			}
		}

		static void PrintSentencesWithoutCommas(string text)
		{
			string[] sentences = text.Split('.', '!', '?');
			Console.WriteLine("Предложения без запятых:");
			foreach (var sentence in sentences)
			{
				if (!sentence.Contains(","))
				{
					Console.WriteLine(sentence.Trim());
				}
			}
		}

		static void FindWordsSameStartEnd(string text)
		{
			string[] words = text.Split(' ', '.', ',', '!', '?', '\n', '\r', '\t');
			Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");
			foreach (var word in words)
			{
				if (word.Length > 1 && char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
				{
					Console.WriteLine(word);
				}
			}
		}
	}
}
