using System.Text.Json;

namespace FuelSurchargeApi
{
	public static class FakeDbAccessor
	{
		private static Dictionary<long, decimal> _customerSurcharges = new();

		public static decimal GetSurchargePercentage(long customerId)
		{
			LoadSurcharges();

			if (_customerSurcharges.ContainsKey(customerId)) {
				return _customerSurcharges[customerId];
			}
			throw new KeyNotFoundException($"Could not find customer id {customerId}");
		}

		// TODO: Should cache or lazy-load this, seems like overkill for this test
		private static void LoadSurcharges()
		{
			using StreamReader r = new("FakeDbData.json");
			string json = r.ReadToEnd();
			_customerSurcharges = JsonSerializer.Deserialize<Dictionary<long, decimal>>(json);
		}
	}
}