using FuelSurchargeApi.Controllers;

namespace FuelSurchargeApiTests
{
	public class FuelSurchargeApiTests
	{
		private FuelSurchargeController _fsController;

		[SetUp]
		public void Setup()
		{
			//TODO: Make the DB use an interface, so that these tests can run against mocked data
			_fsController = new FuelSurchargeController();
		}

		[Test]
		public void TestCustomer1()
		{
			var result = _fsController.CalculateTotal(1, 100);
			Assert.That(result.Total, Is.EqualTo(105));
		}

		[Test]
		public void TestCustomer2()
		{
			var result = _fsController.CalculateTotal(2, 100);
			Assert.That(result.Total, Is.EqualTo(110));
		}

		[Test]
		public void TestCustomer3()
		{
			var result = _fsController.CalculateTotal(3, 100);
			Assert.That(result.Total, Is.EqualTo(107));
		}

		[Test]
		public void TestCustomer4()
		{
			var result = _fsController.CalculateTotal(4, 200);
			Assert.That(result.Total, Is.EqualTo(208.5));
		}
	}
}