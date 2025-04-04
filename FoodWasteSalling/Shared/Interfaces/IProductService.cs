using FoodWasteSalling.Shared.Models;

namespace FoodWasteSalling.Shared.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetProductsAsync(string zipCode);

	}
}
