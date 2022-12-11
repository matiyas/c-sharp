<Query Kind="Statements" />

var arr = new[] { 1, 2, 3 };
var seq = Enumerable.Range(1, arr.Length / 2).ToArray();
var seq2 = Enumerable.Range(1, 10);

Console.WriteLine(Array.Reverse(seq2.ToArray()));
Console.WriteLine(Array.FindIndex(seq, i => arr[..i].Sum() == arr[^i..].Sum()));
