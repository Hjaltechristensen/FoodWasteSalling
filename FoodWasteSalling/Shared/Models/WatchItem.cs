namespace FoodWasteSalling.Shared.Models
{
	public class WatchItem
	{
		public int Id { get; set; }
		public string Keyword { get; set; } = string.Empty;
		public string UserId { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public bool HasMatch { get; set; }
	}
}
