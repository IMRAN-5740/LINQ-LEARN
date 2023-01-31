using GroupJoininLINQ;

List<Category> categories=new List<Category>()
{
    new Category() { Id=1,CategoryName="Programmer" },
    new Category() { Id=2,CategoryName="Designer" },
    new Category() { Id=3,CategoryName="Developer" }
};


List<Student> students = new List<Student>()
{
    new Student(){Id=1,Name="Mohammad Imran",CategoryId=3},
    new Student(){Id=2,Name="Mohammad Sajjat",CategoryId=1},
    new Student(){Id=3,Name="Mohammad Sahin",CategoryId=1},
    new Student(){Id=4,Name="Mohammad Shojib",CategoryId=1},
    new Student(){Id=5,Name="Ibnul Akif Bijoy",CategoryId=2},
    new Student(){Id=6,Name="Munib Fuyad Murad",CategoryId=2},
    new Student(){Id=7,Name="Ibrahim Hossain",CategoryId=3},
    new Student(){Id=8,Name="Mehedi Hasan",CategoryId=3}
};


var methodSyntax = categories.GroupJoin(students,
                    cat => cat.Id,
                    std => std.CategoryId,
                    (cat, std) => new {cat,std}
                    );

foreach(var data in methodSyntax)
{
    Console.WriteLine($"Category Name :{data.cat.CategoryName}:");
    
    foreach(var item in data.std)
    {
        Console.WriteLine($"Student Name :{item.Name}");
    }
    Console.WriteLine("......Category.......");
}


Console.WriteLine("");


var querySyntax = from cat in categories
                  join std in students
                  on cat.Id equals std.CategoryId into stdGroups
                  select new { cat, stdGroups };

foreach (var data in querySyntax)
{
    Console.WriteLine($"Category Name :{data.cat.CategoryName}:");

    foreach (var item in data.stdGroups)
    {
        Console.WriteLine($"Student Name :{item.Name}");
    }
    Console.WriteLine("......End Category.......");
}