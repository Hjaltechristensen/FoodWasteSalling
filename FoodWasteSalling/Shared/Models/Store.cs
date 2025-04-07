namespace FoodWasteSalling.Shared.Models
{
	public class Store
	{
		public string? Id { get; set; }
		public string? Name { get; set; }
		public Address? Address { get; set; }
		public string? Brand { get; set; }
		public List<double>? Coordinates { get; set; }  // Længde og bredde
		public List<StoreHours>? Hours { get; set; }  // Liste af timer
		public string? Type { get; set; }
	}
}
