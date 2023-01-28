
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
using System.Linq;

//List<Employee> employees = new List<Employee>()
//{
//    new Employee(){Id=1,Name="Mohammad Shuvo", Email="shuvo@gmail.com"},
//    new Employee(){Id=2,Name="Muttakin Siam",  Email="siam@gmail.com"},
//    new Employee(){Id=3,Name="Mohammad Sahin", Email="sahin@gmail.com"},
//    new Employee(){Id=4,Name="Mohammad Sajjat",Email="sajjat@gmail.com"},
//    new Employee(){Id=5,Name="Mohammad Saidul",Email="saidul@gmail.com"},
//    new Employee(){Id=6,Name="Mohammad Symoon",Email="symoon@gmail.com"}
//};

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


//var dataSource = new List<object>() {"Imran","Karim","Siam",1,2,3,4,5,"Shuvo"};

//var methodSyntax = dataSource.OfType<string>().Where(x=>x.Length>4).ToList();
//var querySyntax = (from emp in dataSource
//                  where emp is string
//                  select emp).ToList();


//Sorting Different Types of Operation


//var dataSource = new List<int>() { 12,1,34,25,22,4 ,5,6};
//var querySyntax = (from data in dataSource
//                   where data>10
//                  orderby data
//                  select data).ToList();


//var methodSyntax=dataSource.Where(x=>x>10).OrderBy(x=>x).ToList();

//foreach(var data in methodSyntax)
//{
//    Console.WriteLine(data);
//}

//var dataSource = new List<Employee>()
//{
//    new Employee()
//    {
//        Id=1,
//        FirstName="Mohammad",
//        LastName="Imran",
//        Email="imran@gmail.com"
//    },
//     new Employee()
//    {
//        Id=2,
//        FirstName="Irfan",
//        LastName="Sajjat",
//        Email="irfan@gmail.com"
//    },
//      new Employee()
//    {
//        Id=2,
//        FirstName="Irfan",
//        LastName="mondol",
//        Email="karim@gmail.com"
//    },
//       new Employee()
//    {
//        Id=3,
//        FirstName="rohim",
//        LastName="azad",
//        Email="azad@gmail.com"
//    },
//        new Employee()
//    {
//        Id=10,
//        FirstName="sakib",
//        LastName="nakib",
//        Email="sakib@gmail.com"
//    },
//         new Employee()
//    {
//        Id=7,
//        FirstName="asif",
//        LastName="khan",
//        Email="khan@gmail.com"
//    }
//};


//var methodSyntax=dataSource.OrderBy(x => x.Id).ThenBy(x=>x.LastName).ToList();
//foreach (var method in methodSyntax)
//{
//    Console.WriteLine($"Id: {method.Id}  Name : {method.FirstName} {method.LastName} Email :{method.Email}");
//}


//var querySyntax = from data in dataSource
//                  orderby data.Id, data.LastName ascending
//                  select data;

//foreach (var method in querySyntax)
//{
//    Console.WriteLine($"Id: {method.Id}  Name : {method.FirstName} {method.LastName} Email :{method.Email}");
//}


//Reverse Method Operation
//int[] rollNumbers = new int[] { 1,2,3,4,5,56,6,7,8};
//var methodResult=rollNumbers.Reverse();

//var queryResult=(from roll in rollNumbers
//                select roll).Reverse();

//foreach(var data in queryResult)
//{
//    Console.WriteLine(data);
//}


//Reverse Method

//List<string> strings = new List<string>() { "Imran","Karim","Rahim","John","Abraham"};
//foreach(var data in strings)
//{
//    Console.WriteLine(data);
//}
////strings.Reverse(); use anyone
//var reversed=strings.AsEnumerable().Reverse();
//foreach (var data in reversed)
//{
//    Console.WriteLine(data);
//}





//Quantifier Operations
//All
//Any
//Contains


//Student[] students = { 
//    new Student(){StudentName="Imran",Marks=80.0},
//    new Student(){StudentName="Sajjat",Marks=90.0},
//    new Student(){StudentName="Siam",Marks=75.0},
//    new Student(){StudentName="Adeeb",Marks=85.0}

//};
//var methodSyntax = students.All(student=>student.Marks>70);

//var queryWithMixedSyntax=(from std in students
//                select std).All(std=>std.Marks>75);



//Student[] students = {
//    new Student()
//    {
//    StudentName="Imran",Marks=90,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=75},
//                new Subject(){SubjectName="Physics",SubjectMarks=80},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=86},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=91}
//            }
//    },
//    new Student()
//    {
//    StudentName="Siam",Marks=80,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=89},
//                new Subject(){SubjectName="Physics",SubjectMarks=91},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=80},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=91}
//            }
//    },
//    new Student()
//    {
//    StudentName="Shuvo",Marks=85,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=78},
//                new Subject(){SubjectName="Physics",SubjectMarks=82},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=68},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=93}
//            }
//    }
//};


//var methodSyntax = students.Where(std => std.Subjects.All(x => x.SubjectMarks > 70)).Select(x => x).ToList();

//var queryWithMixedSyntax=(from std in students
//                         where std.Subjects.All(x=>x.SubjectMarks>70)
//                         select std).ToList();


//Any

//List<int> students = new List<int>() ;
//var res = students.Any();

//var dataSource = new List<Student>()
//{
//    new Student(){StudentName="Imran",Marks=67},
//    new Student(){StudentName="Siam",Marks=90},
//    new Student(){StudentName="Rahim",Marks=60},
//    new Student(){StudentName="Karim",Marks=70},
//    new Student(){StudentName="Sajjat",Marks=86}
//};

//var methodSyntax = dataSource.Any(x => x.Marks > 80);

//var queryWithMixedSyntax = (from std in dataSource
//                            select std).Any(x => x.Marks > 80);


//Student[] students = {
//    new Student()
//    {
//    StudentName="Imran",Marks=90,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=75},
//                new Subject(){SubjectName="Physics",SubjectMarks=80},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=86},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=91}
//            }
//    },
//    new Student()
//    {
//    StudentName="Siam",Marks=80,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=89},
//                new Subject(){SubjectName="Physics",SubjectMarks=91},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=80},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=91}
//            }
//    },
//    new Student()
//    {
//    StudentName="Shuvo",Marks=85,
//    Subjects=new List<Subject>()
//            {
//                new Subject(){SubjectName="Biology",SubjectMarks=78},
//                new Subject(){SubjectName="Physics",SubjectMarks=82},
//                new Subject(){SubjectName="Chemistry",SubjectMarks=87},
//                new Subject(){SubjectName="Mathematics",SubjectMarks=93}
//            }
//    }
//};

//var methodSyntax = students.Where(x => x.Subjects.Any(x => x.SubjectMarks > 91)).Select(x => x.Subjects.FirstOrDefault(x=>x.SubjectMarks>91)).ToList();

//var querySyntax = (from sub in students
//                   where sub.Subjects.Any(x => x.SubjectMarks > 91)
//                   select sub.Subjects.FirstOrDefault(x => x.SubjectMarks>91)).ToList();


//Contains Quantifier with Example

//List<Student> students = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Sajjat"},
//    new Student(){StudentId=3,StudentName="Motiur"},

//};
//var std = new Student() { StudentId = 1, StudentName = "Imran" };
//students.Add(std);

//var isAvailable = students.Contains(std);

//var comparer = new StudentComparer();

//var methodSyntax = students.Contains(new Student() { StudentId = 1, StudentName = "Imran" }, comparer);



//var querySyntax = (from stk in students
//                   select stk).Contains(new Student() { StudentId = 1, StudentName = "Imran" },comparer);



//List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10,2,3,3,3,5,6,7,8,1,1,1};
//var methodSyntax = numbers.Distinct().ToList();

//var querySyntax=(from num in numbers
//                select num).Distinct().ToList();
//foreach(var number in querySyntax)
//{
//    Console.WriteLine(number);
//}
//List<Student> students = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=3,StudentName="Mark"}
//};
//var compare = new StudentComparer();
//var methodSyntax = students.Distinct(compare).ToList();
//var querySyntax = (from std in students
//                   select std).Distinct(compare).ToList();




//List<string> numbers=new List<string>() {"A","B","C","D"};
//List<string> names=new List<string>() {"C","D","E","F"};

//var res=numbers.Except(names).ToList();


//Except in Set Operations

//List<Student> students=new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=4,StudentName="Zobail"},
//    new Student(){StudentId=5,StudentName="Saidul"},
//};
//List<Student> students1 = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=8,StudentName="jj"},
//    new Student(){StudentId=7,StudentName="hkhj"},
//};
//var compare = new StudentComparer();

////Comparer Way
//var methodSyntax=students.Except(students1,compare).ToList();
//var queryWithMixedSyntax = (from std in students
//                   select std).Except(students1, compare).ToList();
//Annonymous Way
//var compValue = students.Select(x => new { x.StudentId, x.StudentName }).Except(students1.Select(x=> new {x.StudentId,x.StudentName})).ToList();



////Intersec in Set Operations


////List<string> list = new List<string>() { "A","B","C","D","F"};
////List<string> list1 = new List<string>() { "A", "B", "E", "F" };


////var methodSyntax=list.Intersect(list1).ToList();
////var querySyntax = (from name in list1
////                   select name).Intersect(list).ToList();


//List<Student> students = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=4,StudentName="Zobail"},
//    new Student(){StudentId=5,StudentName="Saidul"}
//};
//List<Student> students1 = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=8,StudentName="jj"},
//    new Student(){StudentId=7,StudentName="hkhj"}
//};

//var compare = new StudentComparer();
//var methodSyntax = students.Intersect(students1, compare).ToList();
//var querySyntax = (from name in students
//                   select name).Intersect(students1, compare).ToList();


////Annonymous Way
////var comp = students.Select(x => new { x.StudentId, x.StudentName }).Intersect(students1.Select(x => new { x.StudentId, x.StudentName })).ToList();
///

//Union in Set Operations


//List<string> list = new List<string>() { "A","B","C","D","F"};
//List<string> list1 = new List<string>() { "A", "B", "E", "F" };


//var methodSyntax=list.Intersect(list1).ToList();
//var querySyntax = (from name in list1
//                   select name).Intersect(list).ToList();


//List<Student> students = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=4,StudentName="Zobail"},
//    new Student(){StudentId=5,StudentName="Saidul"}
//};
//List<Student> students1 = new List<Student>()
//{
//    new Student(){StudentId=1,StudentName="Imran"},
//    new Student(){StudentId=2,StudentName="Siam"},
//    new Student(){StudentId=3,StudentName="Shuvo"},
//    new Student(){StudentId=8,StudentName="Rahim"},
//    new Student(){StudentId=7,StudentName="Karim"}
//};

////var compare = new StudentComparer();
//var compare = new ObjcetComparer();
//var methodSyntax = students.Union(students1, compare).ToList();
//var querySyntax = (from name in students
//                   select name).Union(students1, compare).ToList();


////Annonymous Way
//var comp = students.Select(x => new { x.StudentId, x.StudentName }).Union(students1.Select(x => new { x.StudentId, x.StudentName })).ToList();




//List<Teacher> teachers = new List<Teacher>()
//{
//    new Teacher(){Id=1,TeacherName="Khalilur Rahman",TeacherEmail="khalil@gmail.com"},
//    new Teacher(){Id=2,TeacherName="Ejadul Haque",TeacherEmail="ejadul@gmail.com"},
//    new Teacher(){Id=3,TeacherName="Mohir Uddin",TeacherEmail="mohir@gmail.com"},
//    new Teacher(){Id=4,TeacherName="Hamidul Islam",TeacherEmail="hamidul@gmail.com"},
//    new Teacher(){Id=5,TeacherName="Rofiqul Islam",TeacherEmail="rafiqul@gmail.com"}
//};


//List<Teacher> teachers1 = new List<Teacher>()
//{
//    new Teacher(){Id=1,TeacherName="Khalilur Rahman",TeacherEmail="khalil@gmail.com"},
//    new Teacher(){Id=2,TeacherName="Ejadul Haque",TeacherEmail="ejadul@gmail.com"},
//    new Teacher(){Id=3,TeacherName="Mohir Uddin",TeacherEmail="mohir@gmail.com"},
//    new Teacher(){Id=7,TeacherName="Towfik Hasan",TeacherEmail="tawfik@gmail.com"},
//    new Teacher(){Id=8,TeacherName="Potit Mondol",TeacherEmail="potit@gmail.com"}
//};


//var compare = new TeacherComparer();
//var methodSyntax =teachers.Union(teachers1,compare).ToList();

//var querySyntax = (from tea in teachers
//                   select tea).Union(teachers1, compare).ToList();


//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var methodSyntax = numbers.Where(x => x > 5).Take(2).ToList();
//var querySyntax=(from num in numbers
//                select num).Take(2).ToList();



List<int> numbers = new List<int>() { 1,6,8,2,3,5,7};

var methodSyntax = numbers.TakeWhile(x => x < 7).ToList();
var querySyntax= (from num in numbers
                 select num).TakeWhile(x => x < 7).ToList();    

Console.ReadLine();