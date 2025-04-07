namespace FoodWasteSalling.Shared.Models
{
	public class Offer
	{
		public string? Currency { get; set; }
		public double Discount { get; set; }
		public string? Ean { get; set; }
		public DateTime EndTime { get; set; }
		public DateTime LastUpdate { get; set; }
		public double NewPrice { get; set; }
		public double OriginalPrice { get; set; }
		public double PercentDiscount { get; set; }
		public DateTime StartTime { get; set; }
		public decimal Stock { get; set; }
		public string? StockUnit { get; set; }
	}
}
