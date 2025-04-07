using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;

namespace FoodWasteSalling.Client.Services
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _httpClient;

		public ProductService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<Product>> GetProductsAsync(string zipCode)
		{
			//var stores = await _productService.GetProductsAsync(zipCode);  // Henter stores fra API'et

			//var products = new List<Product>();

			//// Hvis du har produkter, kan du tilknytte dem til den korrekte store
			//foreach (var store in stores)
			//{
			//	var product = new Product
			//	{

			//	};

			//	products.Add(product);  // Tilføj produktet til listen
			//}

			//return products;
			throw new NotImplementedException();
		}
	}
}
