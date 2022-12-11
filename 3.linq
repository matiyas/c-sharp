<Query Kind="Statements" />

var s = "Test";
var s2 = s.Select(c => {
	var upper = c >= 'A' && c <= 'Z';
	var lower = c >= 'a' && c <= 'z';
	var min = upper ? 'A' : 'a';
	
	return (char)((c - min + 13) % 26 + min);
});

Console.WriteLine(s2);
