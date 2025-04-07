using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace FoodWasteSalling.Client.Services
{
	public class OfferService : IOfferService
	{
		private readonly HttpClient _httpClient;
		private readonly NavigationManager _navManager;

		public OfferService(HttpClient httpClient, NavigationManager navManager)
		{
			_httpClient = httpClient;
			_navManager = navManager;
		}

		public async Task<EveryFoodWaste> GetStoreByIdAsync(string storeId)
		{
			var baseUrl = _navManager.BaseUri;
			var url = $"{baseUrl}api/stores/store/{storeId}";

			var result = await _httpClient.GetFromJsonAsync<EveryFoodWaste>(url);

			return result ?? new EveryFoodWaste();
		}

		public async Task<List<EveryFoodWaste>> GetStoresAsync(int zipcode)
		{
			var baseUrl = _navManager.BaseUri; // Finder korrekt URL
			var url = $"{baseUrl}api/stores/zipcode/{zipcode}";
			Console.WriteLine($"API URL: {url}");

			var result = await _httpClient.GetFromJsonAsync<List<EveryFoodWaste>>(url);

			return result ?? new List<EveryFoodWaste>();
		}
	}
}
