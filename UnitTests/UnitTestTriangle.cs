using ShapeLibrary;

namespace UnitTests
{
	[TestClass]
	public class UnitTestTriangle
	{
		[TestMethod]
		public void TestGetSquare()
		{
			var tr = new Triangle<int>(3, 4, 5);

			Assert.AreEqual(6.0, tr.GetSquare());
		}

		[TestMethod]
		public void TestIsRectangular1()
		{
			var tr = new Triangle<int>(3, 4, 5);

			Assert.AreEqual(true, tr.IsRectangular());
		}

		[TestMethod]
		public void TestIsRectangular2()
		{
			var tr = new Triangle<int>(3, 3, 3);

			Assert.AreEqual(false, tr.IsRectangular());
		}

		[TestMethod]
		public void TestIsRectangular3()
		{
			var tr = new Triangle<int>(3, 4, 6);

			Assert.AreEqual(false, tr.IsRectangular());
		}
	}
}