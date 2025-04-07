using FoodWasteSalling.Shared.Models;

namespace FoodWasteSalling.Shared.Interfaces
{
	public interface IOfferService
	{
		Task<List<EveryFoodWaste>> GetStoresAsync(int zipcode);
		Task<EveryFoodWaste> GetStoreByIdAsync(string storeId);
	}
}
