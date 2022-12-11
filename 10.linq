<Query Kind="Statements" />

List<int> x = new(new []{ 1, 2, 3 });
x = null;
bool xx = false;
List<int> y = new(new []{ 1, 2, 3 });
List<int> z = new(new []{ 1, 2, 3, 4 });
z ??= y;
var a = new[] { 1,2,3,4 };
int[] b = null;

// b.Length; - nic nie robi. niepoprawne!!!
new StringBuilder();

Console.WriteLine(x);
Console.WriteLine(typeof(int));
Console.WriteLine(nameof(x));
Console.WriteLine(x ?? y);
Console.WriteLine(z);
Console.WriteLine(a?[0]);
Console.WriteLine(b?[0]);

