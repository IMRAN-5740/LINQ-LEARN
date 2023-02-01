List<int> numbers = new List<int>() { 1,2,3,4,5,6,67,78};
//var methodSyntax = numbers.ElementAt(10);
var methodSyntax = numbers.ElementAtOrDefault(10);

//var querySyntax=(from num in numbers
 //               select num ).ElementAt(10);
var querySyntax = (from num in numbers
                   select num).ElementAtOrDefault(10);


Console.ReadLine();