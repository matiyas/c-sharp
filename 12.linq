<Query Kind="Statements" />

var x = " ala ma kota".Split().Select(e => e.Length == 0 ? "" : char.ToUpper(e[0]) + e[1..]);
Console.WriteLine(string.Concat(x));

  
