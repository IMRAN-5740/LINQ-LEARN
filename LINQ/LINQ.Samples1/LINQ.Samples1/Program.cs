
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
    new Employee(){Id=4,Name="Mohammad Sajjat",Email="sajjat@gmail.com"},
    new Employee(){Id=5,Name="Mohammad Saidul",Email="saidul@gmail.com"},
    new Employee(){Id=6,Name="Mohammad Symoon",Email="symoon@gmail.com"}
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

//Select Query and Select Method

//var selectQuery = (from emp in employees
//                    select new
//                    {
//                        CustomerId=emp.Id,
//                        CustomerName = emp.Name,
//                        CustomerEmail = emp.Email
//                    }).ToList();


//var selectMethod = employees.Select(emp => new
//                    {
//                        CustomerId = emp.Id,
//                        CustomerName = emp.Name,
//                        CustomerEmail = emp.Email
//                    }).ToList();

//var selectIndex = employees.Select((emp, index)=> new { Index = index,FullName = emp.Name}).ToList();

//foreach (var employee in selectMethod)
//{
//    Console.WriteLine(" Id:" + employee.CustomerId + " Name :" + employee.CustomerName + " Email :" + employee.CustomerEmail);

//}

//foreach(var data in selectIndex)
//{
//    Console.WriteLine(data);
//}

//SelectMany and Select 

//var dataSource = new List<Employee>()
//{
//    new Employee(){Id=1,Name="Mohammad Imran",Email="imranbsmrstucse@gmail.com",Programming=new List<string> {"C#","C++","SQL"} },
//    new Employee(){Id=2,Name="Muttakin Siam",Email="siam@gmail.com",Programming=new List<string> {"C++","Java","SQL"} },
//    new Employee(){Id=3,Name="Mohammad Shuvo",Email="shuvo@gmail.com",Programming=new List<string> {"C#","SQL","Java"} }

//};


//var methodSyntax = dataSource.SelectMany(x => x.Programming).ToList();

//var querySyntax=from emp in dataSource
//                from skills in emp.Programming
//                select skills;

//foreach(var data in querySyntax)
//{
//    Console.WriteLine("Programming Skill: "+data);
//}

//Console.WriteLine("");

//var dataSource = new List<Employee>()
//{
//    new Employee()
//        {Id=1,Name="Mohammad Imran",Email="imranbsmrstucse@gmail.com",Programming=
//            new List<Tech>
//            {
//                new Tech(){Technology=".Net"},
//                new Tech(){Technology= "SQL"},
//                new Tech(){Technology="C++"}
//            }
//        },
//    new Employee()
//        {Id=2,Name="Muttakin Siam",Email="siam@gmail.com",Programming=
//            new List<Tech>
//            {
//                new Tech(){Technology="Java"},
//                new Tech(){Technology= "C"},
//                new Tech(){Technology="C++"}
//            }
//        },
//     new Employee()
//        {Id=3,Name="Mohammad Shuvo",Email="shuvo@gmail.com",Programming=
//            new List<Tech>
//            {
//                new Tech(){Technology="MS Excell"},
//                new Tech(){Technology= "MS Word"},
//                new Tech(){Technology="MS Powerpoint"}
//            }
//        }



//};

//var queryMethod=dataSource.SelectMany(x => x.Programming).ToList();

//var querySyntax = (from emp in dataSource
//                  from program in emp.Programming
//                  select program).ToList();


//Console.WriteLine("");


//Where Operations
//var dataSource = new List<int>() {1,2,3,4,5,6,7,8,9,10 };


//var querySyntax=(from num in dataSource
//                where num>5
//                select num).ToList();

//var methodSyntax = dataSource.Where(x => x > 5).ToList();\


//OfType Operations


var dataSource = new List<object>() {"Imran","Karim","Siam",1,2,3,4,5,"Shuvo"};

var methodSyntax = dataSource.OfType<string>().Where(x=>x.Length>4).ToList();
var querySyntax = (from emp in dataSource
                  where emp is string
                  select emp).ToList();
                 
Console.WriteLine();