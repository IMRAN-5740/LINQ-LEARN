
using PaginginLINQ;
int totalPageView = 5;
do
{
    
    Console.WriteLine("Enter page number");
    if (int.TryParse(Console.ReadLine(), out int pageNumber))
    {
        if((pageNumber*totalPageView)>SchoolEmployee.GetSchoolEmployees().Count())
        {
            Console.WriteLine("Out of Range Please enter a valid page number");
        }    
        else
        { 
           var methodSyntax = SchoolEmployee.GetSchoolEmployees().Skip((pageNumber - 1) * totalPageView).Take(totalPageView).ToList();
            foreach (var employee in methodSyntax)
            {
                Console.WriteLine($"Employee ID : {employee.EmployeeId}  Employee Name : {employee.EmployeeName}  Employee Email : {employee.Email}");
            }
        }
    }
    else
    {
        Console.WriteLine("Please Enter a valid Page number");
    } 
} while (true);

