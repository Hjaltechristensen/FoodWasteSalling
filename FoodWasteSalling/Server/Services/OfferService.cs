using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;
using Newtonsoft.Json;

namespace FoodWasteSalling.Server.Services
{
	public class OfferService(HttpClient httpClient) : IOfferService
	{
		private readonly HttpClient _httpClient = httpClient;

		public async Task<List<EveryFoodWaste>> GetStoresAsync(int zipcode)
		{
			var url = $"?zip={zipcode}";
			var response = await _httpClient.GetAsync(url);
			var result = await response.Content.ReadAsStringAsync();

			result = result.Replace("\\", "");

			try
			{
				var stores = JsonConvert.DeserializeObject<List<EveryFoodWaste>>(result);
				if (stores != null)
					return stores;
			}
			catch (JsonSerializationException ex)
			{
				Console.WriteLine(ex.StackTrace);
			}

			try
			{
				var singleStore = JsonConvert.DeserializeObject<EveryFoodWaste>(result);
				if (singleStore != null)
					return [singleStore];
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Fejl ved parsing af zip {zipcode}: {ex.Message}");
			}

			return [];
		}


		public async Task<EveryFoodWaste> GetStoreByIdAsync(string storeId)
		{
			var url = $"food-waste/{storeId}";
			var response = await _httpClient.GetAsync(url);
			var result = await response.Content.ReadAsStringAsync();
			result = result.Replace("\\", "");
			var store = JsonConvert.DeserializeObject<EveryFoodWaste>(result);
			if (store != null)
			{
				return store;
			}
			throw new NotImplementedException();
		}
	}
}
