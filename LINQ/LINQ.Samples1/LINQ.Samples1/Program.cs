
//Query Syntax:

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
var querySyntax = from obj in list
                  where obj > 5
                  select obj;

foreach (var item in querySyntax)
{
    Console.WriteLine(item);
}


//Method Syntax:

var methodSyntax=list.Where(x => x > 5);

foreach (var item in methodSyntax)
{
    Console.WriteLine(item);
}

//Mixed Syntax:
var mixedSyntax = (from obj in list
                   select obj).Max();
Console.WriteLine("Max value is :" + mixedSyntax);  