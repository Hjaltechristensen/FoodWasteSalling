namespace FoodWasteSalling.Shared.Models
{
	public class OpeningHours
	{
		public string? Date { get; set; }
		public string? Type { get; set; }
		public string? Open { get; set; }
		public string? Close { get; set; }
		public bool? Closed { get; set; }
		public List<double>? CustomerFlow { get; set; }
	}
}
