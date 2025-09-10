using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace FoodWasteSalling.Client.Services
{
	public class DAWAService(HttpClient httpClient) : IDAWAService
	{
		private readonly HttpClient _httpClient = httpClient;

		public async Task<string> GetDAWAZipAsync(double lon, double lat)
		{
			var x = lon.ToString(CultureInfo.InvariantCulture);
			var y = lat.ToString(CultureInfo.InvariantCulture);

			var baseurl = $"https://api.dataforsyningen.dk/postnumre/reverse?x={x}&y={y}";
			var response = await _httpClient.GetAsync(baseurl);
			if (response.IsSuccessStatusCode)
			{
				var result = await response.Content.ReadAsStringAsync();
				var zip = JsonConvert.DeserializeObject<DAWAZip>(result);
				if (zip != null && !string.IsNullOrEmpty(zip.nr))
					return zip.nr;
			}
			throw new Exception("Failed to fetch data from DAWA API");
		}
	}
}

