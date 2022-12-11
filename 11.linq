<Query Kind="Program" />

void Main()
{
	Console.WriteLine(TypeTest(1));
	Console.WriteLine(TypeTest("ala"));
	Console.WriteLine(TypeTest(1000.2));
	Console.WriteLine(TypeTest(1.3));
	Console.WriteLine(TypeTest('x'));
	Console.WriteLine();	
	Console.WriteLine(Mapping(1));
	Console.WriteLine(Mapping(9));
	Console.WriteLine();	
	Console.WriteLine(TupleMapping(1, 1));
	Console.WriteLine(TupleMapping(9, 0));
}

static string TypeTest (object o) {
	switch (o) {
		case int i:
			return "Int: " + i;
		case string s:
			return "String: " + s;
		case double d when d > 1000:
			return "BigDouble: " + d;
		case double sd:
			return "SmallDouble: " + sd;			
		default:
			return "Object: " + o;
			
	}
}

static string Mapping (int x) {
	return x switch {
		1 => "one",
		2 => "two",
		3 => "three",
		_ => "other"
	};
}

static string TupleMapping (int x, int y) {
	return (x, y) switch {
		(1, 1) => "one, one",
		(2, 2) => "two, two",
		(3, 3) => "three, three",
		_ => "other"
	};
}
