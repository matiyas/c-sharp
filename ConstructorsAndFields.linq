<Query Kind="Program" />

void Main()
{
	//var foo1 = new Foo() { Bar = 10 };
	//var foo2 = new Foo(11);
	//var foo3 = new Foo(12) { Bar = 13 };
	//var foo4 = new Foo(14, 15) { Bar = 16 };
	//var foo5 = new Foo() { Ronly = 17 } // => NOT VALID - field can only be set on initialize;
	//var foo5 = new Foo(17, 18, 19);
	var fooBar = new Foo("Jan", "Kowalski");
	
//	Console.WriteLine(foo1.Bar);
//	Console.WriteLine(foo1.Baz);
//
//	Console.WriteLine(foo2.Bar);
//	
//	Console.WriteLine(foo3.Bar);
//	
//	Console.WriteLine(foo4.Bar);
//	Console.WriteLine(foo4.Baz);

	 //foo5.Ronly = 12; // => NOT VALID - field can only be set on initialize
	
	//Console.WriteLine(foo5.Ronly);
	//Console.WriteLine(Foo.READONLY); // Can only be accessed by type
	//foo5.PrintBar();
	//foo5.PrintFields();
	
	
}

class Foo {
	public int Bar;
	
	public int Baz;
	
	public readonly int Ronly;
	
	public const string READONLY = "nullable";
	
	public string FirstName, LastName;
	
	
	public Foo () {}
	
	public Foo (int bar) => Bar = bar;
	
	public Foo (int bar, int baz) : this(bar) => Baz = baz;
	
	public Foo (int bar, int baz, int ronly) : this(bar, baz) => Ronly = ronly;
	
	//public Foo (string ronly) => READONLY = ronly; => NOT VALID - field can only be set when initialized
	
	// Invoked First
	public Foo (string firstName) {
		Console.WriteLine("string firstName");
		FirstName = firstName;
	}
	
	// Invoked Last
	public Foo (string firstName, string lastName) : this(firstName) {
		Console.WriteLine("string firstName, string lastName");
		LastName = lastName;
	}
	
	
	public void PrintBar () => Console.WriteLine(this.Bar);
	
	public void PrintFields () {
		PrintField("Bar", this.Bar.ToString());
		PrintField("Baz", this.Baz.ToString());
		PrintField("READONLY", READONLY);
	
		//void PrintField (string name, int field) => Console.WriteLine($"{name}: {field}");  ==>> local methods cannot be overloaded
		static void PrintField (string name, string field) => Console.WriteLine($"{name}: {field}");
	}
}

//==============================================================================================+
// 					     READONLY                    |                  CONST                   |
// --------------------------------------------------+------------------------------------------+
//       can be accessed by type or object           |        can be accesed only by type       |
// --------------------------------------------------+------------------------------------------+
// can be set in initializers or on declaration time | can only be accessed on declaration time |
// --------------------------------------------------+------------------------------------------+