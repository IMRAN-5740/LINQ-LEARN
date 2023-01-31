using LeftOuterJoininLINQ;

List<Student> students = new List<Student>()
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

var querySyntax =( from std in students
                  join adrs in addresses
                  on std.AddressId equals adrs.Id into stdAddress
                  from studentAddress in stdAddress.DefaultIfEmpty()
                  select new {StudentName=std.Name, Address=studentAddress!=null? studentAddress.AddressLine:"NA" }).ToList();
Console.WriteLine();