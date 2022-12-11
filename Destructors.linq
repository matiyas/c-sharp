<Query Kind="Program" />

void Main()
{
	var rect1 = new Rectangle(5, 10);
	var rect2 = new Rectangle(15, 20);
	int a, b, g, h, i;
	
	rect1.Deconstruct();
	rect2.Deconstruct(out int x, out int y);
	rect2.Deconstruct(out a, out b);
	(int c, int d) = rect2;
	var (e, f) = rect2;
	(g, h) = rect2;
	(i, int j) = rect2;
	
	Console.WriteLine($"x: {x}, y: {y}");
	Console.WriteLine($"a: {a}, b: {b}");
	Console.WriteLine($"c: {c}, d: {d}");
	Console.WriteLine($"e: {e}, f: {f}");
	Console.WriteLine($"g: {g}, h: {h}");
	Console.WriteLine($"i: {i}, j: {j}");
}

class Rectangle {
	public int Width;
	public int Height;
	
	public Rectangle(int width, int height) {
		Width = width;
		Height = height;
	}
	
	public void Deconstruct () {
		Console.WriteLine("Just destroy");
	}
	
	public void Deconstruct (out int width, out int height) {
		Console.WriteLine("Destroy and return fields");
		
		width = Width;
		height = Height;
	}
}

// You can define other methods, fields, classes and namespaces here