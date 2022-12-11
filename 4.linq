<Query Kind="Program" />

namespace N { 
	class A { 
		public static int x; 
	}
	
	class Program {
		public static void Main(string[] args) {
			Console.WriteLine(A.x);
		}
	}
}
