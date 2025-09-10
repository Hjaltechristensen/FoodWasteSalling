using System.Text.Json.Serialization;

namespace FoodWasteSalling.Shared.Models
{
	public class Clearance
	{
		public Offer? Offer { get; set; }
		public Product? Product { get; set; }
		public bool IsImageVisible { get; set; } // Flag til at holde styr på synligheden

		[JsonIgnore] // Hvis du bruger JSON serialization, forhindrer vi serialisering af denne
		public Store? Store { get; set; }
	}
}
