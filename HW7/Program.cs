namespace HW7;

class Program
{
	static void Main(string[] args)
	{
		Inventory inventory = new Inventory();

		inventory.AddProduct(new Product(1, "Яблоки", 12.5m, 150));
		inventory.AddProduct(new Product(2, "Бананы", 9.3m, 100));
		inventory.AddProduct(new Product(3, "Огурцы", 6.4m, 50));
		inventory.AddProduct(new Product(4, "Арбузы", 17.9m, 300));
		inventory.AddProduct(new Product(5, "Дыни", 14.3m, 200));

		// Вывод списка всех продуктов
		Console.WriteLine("Список всех продуктов:");
		inventory.DisplayAllProducts();

		// Получение суммы всех продуктов
		decimal totalValue = inventory.CalculateInventoryValue();
		Console.WriteLine($"\nСумма всех продуктов: {totalValue} BYN");

		// Удаление продукта по ID
		inventory.RemoveProduct(2);

		// Вывод списка всех продуктов после удаления
		Console.WriteLine("\nСписок продуктов после удаления по ID 2:");
		inventory.DisplayAllProducts();

		// Получение суммы всех продуктов после удаления
		totalValue = inventory.CalculateInventoryValue();
		Console.WriteLine($"\nСумма всех продуктов после удаления по ID 2: {totalValue} BYN");
	}
}
