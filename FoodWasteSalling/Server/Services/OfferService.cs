using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;
using Newtonsoft.Json;

namespace FoodWasteSalling.Server.Services
{
	public class OfferService : IOfferService
	{
		private readonly HttpClient _httpClient;

		public OfferService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<EveryFoodWaste>> GetStoresAsync(int zipcode)
		{
			//var zipCode = "8000";
			var url = $"?zip={zipcode}";
			var response = await _httpClient.GetAsync(url);
			var result = await response.Content.ReadAsStringAsync();

			result = result.Replace("\\", "");
			var stores = JsonConvert.DeserializeObject<List<EveryFoodWaste>>(result);

			//var storeResponse = JsonConvert.DeserializeObject<StoreResponse>(result);
			return stores;
		}

		public async Task<EveryFoodWaste> GetStoreByIdAsync(string storeId)
		{
			var url = $"food-waste/{storeId}";
			var response = await _httpClient.GetAsync(url);
			var result = await response.Content.ReadAsStringAsync();
			result = result.Replace("\\", "");
			var store = JsonConvert.DeserializeObject<EveryFoodWaste>(result);
			return store;
		}
	}
}
