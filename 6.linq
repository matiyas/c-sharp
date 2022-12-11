<Query Kind="Program" />

// ref - kopiowanie referencji. Wartość może być zmieniona w metodzie.
// in  - j. w. Wartość nie może być zmieniona w metodzie (readonly). Przyspiesza działanie programu (wartość nie musi być kopiowana np. duży struct).
// out - wartość jest zawsze inicjalizowana w metodzie.

namespace Params {
	class Program {
		public static void Main (string[] args) {
			var x = 10;
			Change(out _);
			Change(out x);
			Change(out int y);
			ChangeIn(in x);
			
			Console.WriteLine(x + 1);
			Console.WriteLine(x);
			Console.WriteLine(y);
		}
		
		private static void Change (out int x) {
			x = 20;
		}
		
		private static void ChangeIn(in int x) {
			Console.WriteLine(x);
		}
	}
}