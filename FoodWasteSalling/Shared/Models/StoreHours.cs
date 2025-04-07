namespace FoodWasteSalling.Shared.Models
{
	public class StoreHours
	{
		public string? Date { get; set; }
		public string? Type { get; set; }
		public string? Open { get; set; }
		public string? Close { get; set; }
		public bool Closed { get; set; }
		public List<double>? CustomerFlow { get; set; }  // Liste med customerFlow-data
	}
}
