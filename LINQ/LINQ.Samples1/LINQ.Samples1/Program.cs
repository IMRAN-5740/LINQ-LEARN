
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

using LINQ.Samples1;

List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Mohammad Shuvo", Email="shuvo@gmail.com"},
    new Employee(){Id=2,Name="Muttakin Siam",  Email="siam@gmail.com"},
    new Employee(){Id=3,Name="Mohammad Sahin", Email="sahin@gmail.com"},
    new Employee(){Id=4,Name="Muttakin Sajjat",Email="sajjat@gmail.com"},
    new Employee(){Id=5,Name="Mohammad Saidul",Email="saidul@gmail.com"},
    new Employee(){Id=6,Name="Muttakin Symoon",Email="symoon@gmail.com"}
};

//IEnumerable<Employee> employees1 =from emp in employees
//                                  where emp.Id == 2
//                                  select emp;


//foreach(var data in employees1)
//{
//    Console.WriteLine("Id :"+data.Id+ " and Name :"+data.Name);
//}



//IQueryable

//IQueryable<Employee> employees2 = employees.AsQueryable().Where(x => x.Id == 1);
//foreach(var data in employees2)
//{
//    Console.WriteLine("Id :" + data.Id + " and Name :" + data.Name);
//}


//var allEmployee= (from emp in employees
//                 select emp).ToList();

//foreach(var data in allEmployee)
//{
//    Console.WriteLine("Id :" + data.Id + " and Name :" + data.Name);
//}

//var propQuery=(from emp in employees
//              select emp.Id).ToList();


//var propMethod = employees.Select(x=>x.Id.ToString()).ToList();

//foreach(var data in propMethod)
//{
//    Console.WriteLine("Id :"+data);
//}


var selectQuery = (from emp in employees
                    select new
                    {
                        CustomerId=emp.Id,
                        CustomerName = emp.Name,
                        CustomerEmail = emp.Email
                    }).ToList();


var selectMethod = employees.Select(emp => new
                    {
                        CustomerId = emp.Id,
                        CustomerName = emp.Name,
                        CustomerEmail = emp.Email
                    }).ToList();

foreach (var employee in selectMethod)
{
    Console.WriteLine(" Id:"+employee.CustomerId + " Name :"+employee.CustomerName + " Email :"+employee.CustomerEmail);

}




