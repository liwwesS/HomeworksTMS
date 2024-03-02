namespace HW4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку текста:");
			var input = Console.ReadLine();

			var exit = false;
			while (!exit)
			{
				Console.WriteLine("\nНа выбор следующие действия:");
				Console.WriteLine("1. Найти слова, содержащие максимальное количество цифр.");
				Console.WriteLine("2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
				Console.WriteLine("3. Заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять».");
				Console.WriteLine("4. Выход.");
                Console.Write("\nВаше действие: ");

                var choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						FindWordsWithMostDigits(input);
						break;
					case "2":
						FindLongestWord(input);
						break;
					case "3":
						ReplaceDigitsWithWords(input);
						break;
					case "4":
						exit = true;
						break;
					default:
						Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
						break;
				}
			}
		}

		static void FindWordsWithMostDigits(string text)
		{
			var words = text.Split(' ', '.', ',', '!', '?');

			var maxDigitsCount = 0;

			List<string> wordsWithMaxDigits = new List<string>();

			foreach (var word in words)
			{
				var digitCount = 0;
				foreach (var ch in word)
				{
					if (char.IsDigit(ch))
					{
						digitCount++;
					}
				}

				if (digitCount > maxDigitsCount)
				{
					maxDigitsCount = digitCount;
					wordsWithMaxDigits.Clear();
					wordsWithMaxDigits.Add(word);
				}
				else if (digitCount == maxDigitsCount && digitCount != 0)
				{
					wordsWithMaxDigits.Add(word);
				}
			}

			if (maxDigitsCount == 0)
			{
				Console.WriteLine("В введенных словах не найдено цифр!");
			}
			else
			{
				Console.WriteLine("Слова с максимальным количеством цифр:");
				foreach (var word in wordsWithMaxDigits)
				{
					Console.WriteLine(word);
				}
			}
		}

		static void FindLongestWord(string text)
		{
			var words = text.Split(' ', '.', ',', '!', '?');

			var longestWord = "";
			var longestLength = 0;

			Dictionary<string, int> wordCounts = new Dictionary<string, int>();

			foreach (var word in words)
			{
				var length = word.Length;
				if (length > longestLength)
				{
					longestLength = length;
					longestWord = word;
					wordCounts.Clear();
					wordCounts[word] = 1;
				}
				else if (length == longestLength)
				{
					if (wordCounts.ContainsKey(word))
					{
						wordCounts[word]++;
					}
					else
					{
						wordCounts.Add(word, 1);
					}
				}
			}

			Console.WriteLine($"Самое длинное слово: {longestWord}");
			Console.WriteLine($"Количество повторений: {wordCounts[longestWord]}");
		}

		static void ReplaceDigitsWithWords(string text)
		{
			string[] numbersWords = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
			var result = "";

			foreach (var ch in text)
			{
				if (char.IsDigit(ch))
				{
					var digit = ch - '0';
					result += numbersWords[digit];
				}
				else
				{
					result += ch;
				}
			}

			Console.WriteLine($"Текст после замены: {result}");
		}
	}
}
