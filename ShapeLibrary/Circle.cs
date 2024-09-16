using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
	public class Circle<T> : IShape
	{
		double radius { get; set; }

		public Circle(T radius)
		{
			this.radius = Convert.ToDouble(radius);
		}

		public double GetSquare()
		{
			return Math.PI * radius * radius;
		}
	}
}
