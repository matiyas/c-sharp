<Query Kind="Program" />

void Main()
{
	var foo = new Foo() { F = 17 };
	
	//foo.A = 11;  ==>>  Not possible. Setter is not defined.
	foo.B = 12;
	Console.WriteLine(foo.B);
	
	foo.C = 13;
	Console.WriteLine(foo.C);
	
	foo.D = 14;
	Console.WriteLine(foo.D);
	
	//foo.E = 15;  ==>>  Not possible. Setter is private.
	foo.SetE(15);
	Console.WriteLine(foo.E);
	
	//foo.F = 16;  ==>> The only way to set this property valus is in initializer
	Console.WriteLine(foo.F);
}

class Foo {
	private int c, d, f;

	public int A { get; } = 10;
	public int B { get; set; }
	public int C {
		get => c;
		set => c = value;
	} // = 10  ==>> Only auto-implemented properties can have initializers;
	public int D {
		get {
			Console.WriteLine("GET d");
			return d;
		}
		set {
			Console.WriteLine("SET d");
			d = value;
		}
	}
	public int E { get; private set; }
	public int F { 
		get => f; 
		init => f = value ; // or just init;. It's better not to use (lack of control).
	}
	
	
	public void SetE (int e) {
		E = e;
		//F = 17;  ==>>  Not possible. Can only be initialized in object initializer: new Foo() { F = 17 }
	}
}

// You can define other methods, fields, classes and namespaces here