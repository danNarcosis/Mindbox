using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
	[TestClass]
	public class UnitTestCircle
	{
		[TestMethod]
		public void TestGetSquare()
		{
			var circle = new Circle<int>(1);

			Assert.AreEqual(Math.PI, circle.GetSquare());
		}
	}
}
