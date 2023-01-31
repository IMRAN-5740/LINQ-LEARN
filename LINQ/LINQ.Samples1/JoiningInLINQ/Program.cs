//using JoiningInLINQ;

//List<Subject>subjects=new List<Subject>()
//{
//     new Subject(){SubjectId=1,SubjectName="CSE",StudentID=1},
//     new Subject(){SubjectId=2,SubjectName="EEE",StudentID=2},
//     new Subject(){SubjectId=3,SubjectName="ACCE",StudentID=0},
//     new Subject(){SubjectId=4,SubjectName="CE",StudentID=5},
//     new Subject(){SubjectId=5,SubjectName="FAE",StudentID=0},
//     new Subject(){SubjectId=6,SubjectName="ARC",StudentID=3}
//};

//List<Student> students = new List<Student>()
//{
//    new Student(){Id=1,StudentName="Mohammad Imran" ,StudentEmail="imran@gmail.com"},
//    new Student(){Id=2,StudentName="A " ,StudentEmail="a@gmail.com"},
//    new Student(){Id=3,StudentName="B " ,StudentEmail="b@gmail.com"},
//    new Student(){Id=4,StudentName="C " ,StudentEmail="c@gmail.com"},
//    new Student(){Id=5,StudentName="D " ,StudentEmail="d@gmail.com"},
//    new Student(){Id=6,StudentName="E " ,StudentEmail="e@gmail.com"}
//};


//List<Marks> marks = new List<Marks>()
//{
//    new Marks(){Id=1,StudentId=1,TMarks=80},
//    new Marks(){Id=2,StudentId=2,TMarks=90},
//    new Marks(){Id=3,StudentId=3,TMarks=95}
//};

//var methodSyntax = subjects.Join(students,
//                                sub => sub.StudentID,
//                                std => std.Id,
//                                (sub, std) => new
//                                {
//                                    StudentId       = std.Id,
//                                    StudentName     = std.StudentName,
//                                    StudentEmail    = std.StudentEmail,
//                                    SubjectName     = sub.SubjectName
//                                }
//                                ).ToList();

//var querySyntax=(
//                    from sub in subjects 
//                                join std in students
//                                on sub.StudentID equals std.Id
//                                join mark in marks 
//                                on sub.SubjectId equals mark.StudentId
//                                select new
//                                    {
//                                        StudentName=std.StudentName,
//                                        StudentEmail=std.StudentEmail,
//                                        SubjectName =sub.SubjectName,
//                                        TotalMarks=mark.TMarks
//                                    }
//                ).ToList();

//foreach(var s in querySyntax)
//{
//    Console.WriteLine($"Student Name :{s.StudentName} StudentEmail :{s.StudentEmail} SubjectName :{s.SubjectName} Total Marks={s.TotalMarks}");
//}
//Console.WriteLine();


using JoiningInLINQ;

List<Student> students=new List<Student>()
{
    new Student(){Id=1,Name="A",AddressId=1},
    new Student(){Id=2,Name="B",AddressId=0},
    new Student(){Id=3,Name="C",AddressId=2},
    new Student(){Id=4,Name="D",AddressId=0},
    new Student(){Id=5,Name="E",AddressId=3},
};

List<Address> addresses = new List<Address>()
{
    new Address(){Id=1,AddressLine="Address Line 1"},
    new Address(){Id=2,AddressLine="Address Line 2"},
    new Address(){Id=3,AddressLine="Address Line 3"},
    new Address(){Id=4,AddressLine="Address Line 4"},
    new Address(){Id=5,AddressLine="Address Line 5"},
};

List<Marks> marks = new List<Marks>()
{
    new Marks(){Id=1,StudentId=1,TMarks=80},
    new Marks(){Id=2,StudentId=2,TMarks=90},
    new Marks(){Id=3,StudentId=3,TMarks=95}
};



var methodSyntax = students.Join(addresses,
                            std => std.AddressId,
                            address => address.Id,
                            (std,address)=>new{ std, address })
                            .Join(marks,
                            student=>student.std.Id,
                            m=>m.StudentId,
                            (student, m) => new {student,m})
                            .Select(x => new
                            {
                                StudentId=x.student.std.Id,
                                StudentName=x.student.std.Name,
                                StudentAddress=x.student.address.AddressLine,
                                StudentMarks=x.m.TMarks
                            }).ToList();


var querySyntax = (
                        from std in students
                        join adrs in addresses
                        on std.AddressId equals adrs.Id
                        join mark in marks
                        on std.Id equals mark.StudentId
                        select new
                        {
                            StudentId = std.Id,
                            StudentName = std.Name,
                            StudentAddress = adrs.AddressLine,
                            StudentMarks = mark.TMarks
                        }
                  ).ToList();

foreach(var data in methodSyntax)
{
    Console.WriteLine($"Student ID :{data.StudentId} Student Name :{data.StudentName} Student Address= {data.StudentAddress} Student Marks= {data.StudentMarks}");
}

Console.WriteLine("..............Break.............");
foreach (var data in querySyntax)
{
    Console.WriteLine($"Student ID :{data.StudentId} Student Name :{data.StudentName} Student Address= {data.StudentAddress} Student Marks= {data.StudentMarks}");
}


Console.ReadLine();

