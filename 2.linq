<Query Kind="Statements" />

// Rank
// arr[2..^1]
// arr[2..]
// IndexOf
// LastIndexOf
// Find
// FindIndex
// FindLastIndex
// GetValue
// SetValue
// CreateInstance
// arr.GetLength(dimension)

var arr = new[] { "ala", "ma", "kota" };
char[] arr2 = { 'q', 'w', 'e', 'r', 't', 'y' };
var multiDimArr = new[,] {
	{ 1, 2 },
	{ 1, 2 },
	{ 1, 2 },
	{ 1, 2 },
	{ 1, 2 }	
};
var jaggArr = new int[][] {
	new[] { 1, 2, 3 },
	new[] { 2, 3 },
	new[] { 4, 5, 6, 7 },
	new int[] { }
};
arr.SetValue("nie ma", 1);

Console.WriteLine(arr[1..]);
Console.WriteLine(multiDimArr.GetLength(1));
Console.WriteLine(jaggArr.GetLength(0));