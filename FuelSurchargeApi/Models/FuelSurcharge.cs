namespace FuelSurchargeApi.Models
{
	public class FuelSurcharge
	{
		public long CustomerId { get; set; }
		public decimal Subtotal { get; set; }
		public decimal SurchargeAmount { get; set; }
		public decimal Total { get; set; }
	}
}