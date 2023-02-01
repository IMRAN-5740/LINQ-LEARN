//List<int> numbers = new List<int>() { 1,2,3,4,5,6,67,78};
////var methodSyntax = numbers.ElementAt(10);
//var methodSyntax = numbers.ElementAtOrDefault(10);

////var querySyntax=(from num in numbers
// //               select num ).ElementAt(10);
//var querySyntax = (from num in numbers
//                   select num).ElementAtOrDefault(10);



//List<int> numbers = new List<int>() { 5, 2, 3, 4, 5, 6, 2, 78 };
//var ms1 = numbers.Where(x => x > 5);
//var methodSyntax = numbers.First(x => x > 5);
 //var querySyntax = (from num in numbers
  //                  select num).FirstOrDefault(x => x > 5);

//List<int> numbers = new List<int>() { 5, 2, 3, 4, 5, 6, 2, 78 };
//var ms1 = numbers.Last();
//var methodSyntax = numbers.Last(x => x > 5);
//var querySyntax = (from num in numbers
//                   select num).LastOrDefault();


List<int> numbers = new List<int>() { 5 };
var ms1 = numbers.Single();
var methodSyntax = numbers.SingleOrDefault();
var querySyntax = (from num in numbers
                   select num).SingleOrDefault();
Console.ReadLine();