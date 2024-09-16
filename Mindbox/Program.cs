namespace Mindbox
{
	using ShapeLibrary;

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			var tr = new Triangle<int>(3, 4, 5);
			var circle = new Circle<int>(1);

			Console.WriteLine($"tr.square: {tr.GetSquare()}");
			Console.WriteLine($"tr.rectangular: {tr.IsRectangular()}");
			Console.WriteLine($"circle.square: {circle.GetSquare()}");


			IShape shape1 = new Triangle<int>(3, 4, 6);
			Console.WriteLine($"shape1.square: {shape1.GetSquare()}");
			IShape shape2 = new Circle<int>(3);
			Console.WriteLine($"shape2.square: {shape2.GetSquare()}");

			Console.ReadLine();
		}
	}
}
