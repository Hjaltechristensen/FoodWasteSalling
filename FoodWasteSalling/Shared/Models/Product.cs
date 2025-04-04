namespace FoodWasteSalling.Shared.Models
{
	public class Product
	{
		public Dictionary<string, object> Categories { get; set; }
		public string Description { get; set; }
		public string Ean { get; set; }
		public string Image { get; set; }
	}
}
