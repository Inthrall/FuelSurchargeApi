using FuelSurchargeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelSurchargeApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FuelSurchargeController : ControllerBase {

		//TODO: Throwing errors is currently unhandled
		[HttpPost(Name = "CalculateTotal")]
		public FuelSurcharge CalculateTotal(long customerId, int subtotal)
		{
			var surchargeAmount = subtotal * (FakeDbAccessor.GetSurchargePercentage(customerId) / 100);

			return new FuelSurcharge
			{
				CustomerId = customerId,
				Subtotal = subtotal,
				SurchargeAmount = surchargeAmount,
				Total = subtotal + surchargeAmount
			};
		}
	}
}