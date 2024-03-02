
namespace HW7;

internal class Inventory
{
	private List<Product> products;

	public Inventory()
	{
		products = new List<Product>();
	}

	public void AddProduct(Product product)
	{
		products.Add(product);
	}

	public void RemoveProduct(int id)
	{
		products.RemoveAll(p => p.Id == id);
	}

	public decimal CalculateInventoryValue()
	{
		decimal totalValue = 0m;
		foreach (var product in products)
		{
			totalValue += product.Price * product.Count;
		}
		return totalValue;
	}

	public void DisplayAllProducts()
	{
		foreach (var product in products)
		{
			Console.WriteLine($"ID: {product.Id}, Название: {product.Name}, Цена за 1 продукт: {product.Price} BYN, Количество: {product.Count}");
		}
	}
}
