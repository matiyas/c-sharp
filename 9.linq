<Query Kind="Statements" />

var arr = new[] { 5, 8, 6, 3, 4 };
var orderedOdds = new Queue<int>(arr.Where(e => e % 2 == 1).Order());
Console.WriteLine(arr.Select(e => e % 2 == 1 ? orderedOdds.Dequeue() : e));