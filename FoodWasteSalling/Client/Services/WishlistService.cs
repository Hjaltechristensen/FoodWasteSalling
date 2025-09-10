using FoodWasteSalling.Shared.Interfaces;

namespace FoodWasteSalling.Client.Services
{
	public class WishlistService : IWishlistService
	{
		public event Action<int>? OnBadgeChanged;

		public void UpdateBadge(int count)
		{
			OnBadgeChanged?.Invoke(count);
		}

	}
}
