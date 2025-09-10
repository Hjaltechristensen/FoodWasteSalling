namespace FoodWasteSalling.Shared.Interfaces
{
	public interface IDAWAService
	{
		Task<string> GetDAWAZipAsync(double lon, double lat);
	}
}
