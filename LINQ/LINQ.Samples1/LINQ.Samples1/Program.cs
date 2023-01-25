
////Query Syntax:

//List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//var querySyntax = from obj in list
//                  where obj > 5
//                  select obj;

//foreach (var item in querySyntax)
//{
//    Console.WriteLine(item);
//}


////Method Syntax:

//var methodSyntax=list.Where(x => x > 5);

//foreach (var item in methodSyntax)
//{
//    Console.WriteLine(item);
//}

////Mixed Syntax:
//var mixedSyntax = (from obj in list
//                   select obj).Max();
//Console.WriteLine("Max value is :" + mixedSyntax);  



//IEnumerable

List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Mohammad Imran"},
    new Employee(){Id=2,Name="Muttakin Siam"},
     new Employee(){Id=1,Name="Mohammad Sahin"},
    new Employee(){Id=2,Name="Muttakin Siam"}
};

//IEnumerable<Employee> employees1 =from emp in employees
//                                  where emp.Id == 2
//                                  select emp;


//foreach(var data in employees1)
//{
//    Console.WriteLine("Id :"+data.Id+ " and Name :"+data.Name);
//}



//IQueryable

IQueryable<Employee> employees2 = employees.AsQueryable().Where(x => x.Id == 1);
foreach(var data in employees2)
{
    Console.WriteLine("Id :" + data.Id + " and Name :" + data.Name);
}


class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}




