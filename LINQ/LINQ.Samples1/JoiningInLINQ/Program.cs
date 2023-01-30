using JoiningInLINQ;

List<Subject>subjects=new List<Subject>()
{
     new Subject(){SubjectId=1,SubjectName="CSE",StudentID=1},
     new Subject(){SubjectId=2,SubjectName="EEE",StudentID=2},
     new Subject(){SubjectId=3,SubjectName="ACCE",StudentID=0},
     new Subject(){SubjectId=4,SubjectName="CE",StudentID=1},
     new Subject(){SubjectId=5,SubjectName="FAE",StudentID=2},
     new Subject(){SubjectId=6,SubjectName="ARC",StudentID=3}
};

List<Student> students = new List<Student>()
{
    new Student(){Id=1,StudentName="Mohammad Imran" ,StudentEmail="imran@gmail.com"},
    new Student(){Id=2,StudentName="A " ,StudentEmail="a@gmail.com"},
    new Student(){Id=3,StudentName="B " ,StudentEmail="b@gmail.com"},
    new Student(){Id=4,StudentName="C " ,StudentEmail="c@gmail.com"},
    new Student(){Id=5,StudentName="D " ,StudentEmail="d@gmail.com"},
    new Student(){Id=6,StudentName="E " ,StudentEmail="e@gmail.com"}
};


var querySyntax=(from sub in subjects 
                join std in students
                on sub.StudentID equals std.Id
                select new
                {
                    StudentName=std.StudentName,
                    StudentEmail=std.StudentEmail,
                    SubjectId = sub.SubjectId,
                    SubjectName =sub.SubjectName
                }).ToList();




foreach(var s in querySyntax)
{
    Console.WriteLine($"Student Name :{s.StudentName} StudentEmail :{s.StudentEmail} SubjectId :{s.SubjectId} SubjectName :{s.SubjectName}");
}
Console.WriteLine();