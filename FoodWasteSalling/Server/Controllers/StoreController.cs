using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodWasteSalling.Server.Controllers
{
	[Route("api/stores")]
	[ApiController]
	public class StoreController(IOfferService offerService) : Controller
	{
		private readonly IOfferService _offerService = offerService;

		[HttpGet]
		[Route("zipcode/{zipcode}")]
		public async Task<IEnumerable<EveryFoodWaste>> GetAllStores(int zipcode)
		{
			return await _offerService.GetStoresAsync(zipcode);
		}

		[HttpGet]
		[Route("store/{storeId}")]
		public async Task<EveryFoodWaste> GetStoreById(string storeId)
		{
			return await _offerService.GetStoreByIdAsync(storeId);
		}
	}
}
