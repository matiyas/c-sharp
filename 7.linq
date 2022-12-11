<Query Kind="Program" />

namespace Params {
	class Program {
		public static void Main (string[] args) {
			ParamsTest(1, 2, 3, 4, 5);
			ParamsTest(6, 7);
			ParamsTest(6, 7, new[] { 8, 9, 10 });
			ParamsTest(11);
			ParamsTest(args: new[] { 12, 13, 14 });
			ParamsTest(args: new[] { 99, 98, 97 }, x: 69);
		}
		
		private static void ParamsTest (int x = 3, int y = default, params int[] args /* To samo co *args */) {
			Console.WriteLine($"x = {x}");
			Console.WriteLine($"y = {y}");
			Console.WriteLine($"args = {{ {string.Join(", ", args)} }}");
			Console.WriteLine();
		}
	}
}