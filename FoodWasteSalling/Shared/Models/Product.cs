namespace FoodWasteSalling.Shared.Models
{
	public class Product
	{
		public Dictionary<string, object>? Categories { get; set; }
		public string? Description { get; set; }
		public string? Ean { get; set; }
		public string? Image { get; set; }
		public List<string> SplitCategoryList { get; set; } = [];

		public void SplitCategories()
		{
			if (Categories != null && Categories.ContainsKey("da"))
			{
				var raw = Categories["da"]?.ToString();
				if (!string.IsNullOrEmpty(raw))
				{
					SplitCategoryList = raw.Split('>').Select(s => s.Trim()).ToList();
				}
			}
		}


	}
}
