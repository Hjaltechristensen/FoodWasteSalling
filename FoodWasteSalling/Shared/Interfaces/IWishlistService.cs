namespace FoodWasteSalling.Shared.Interfaces
{
	public interface IWishlistService
	{
		event Action<int>? OnBadgeChanged;
		void UpdateBadge(int count);
	}
}
