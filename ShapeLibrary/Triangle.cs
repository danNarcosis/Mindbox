namespace ShapeLibrary
{
	public class Triangle<T> : IShape
	{
		double a { get; set; }
		double b { get; set; }
		double c { get; set; }

		public Triangle(T a, T b, T c)
		{
			this.a = Convert.ToDouble(a);
			this.b = Convert.ToDouble(b);
			this.c = Convert.ToDouble(c);
		}

		public double GetSquare()
		{
			double p = (a + b + c) / 2.0;

			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		public bool IsRectangular()
		{
			double hypotenuse = Math.Max(Math.Max(a, b), c);

			double catheter1 = a == hypotenuse ? b : a;
			double catheter2 = c == hypotenuse ? b : c;

			return catheter1 * catheter1 + catheter2 * catheter2 == hypotenuse * hypotenuse;
		}
	}
}
