using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginginLINQ
{
    public class SchoolEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public static List<SchoolEmployee> GetSchoolEmployees()
        {
            return new List<SchoolEmployee>()
        {

            new SchoolEmployee(){EmployeeId=1,EmployeeName="Mohamamd Imran",Email="imranbsmrstucse@gmail.com"},
            new SchoolEmployee(){EmployeeId=2,EmployeeName="A Imran",Email="a@gmail.com"},
            new SchoolEmployee(){EmployeeId=3,EmployeeName="B Imran",Email="b@gmail.com"},
            new SchoolEmployee(){EmployeeId=4,EmployeeName="C Imran",Email="v@gmail.com"},
            new SchoolEmployee(){EmployeeId=5,EmployeeName="D Imran",Email="d@gmail.com"},
            new SchoolEmployee(){EmployeeId=6,EmployeeName="E Imran",Email="e@gmail.com"},
            new SchoolEmployee(){EmployeeId=7,EmployeeName="F Imran",Email="f@gmail.com"},
            new SchoolEmployee(){EmployeeId=8,EmployeeName="G Imran",Email="g@gmail.com"},
            new SchoolEmployee(){EmployeeId=9,EmployeeName="H Imran",Email="h@gmail.com"},
            new SchoolEmployee(){EmployeeId=10,EmployeeName="I Imran",Email="i@gmail.com"},
            new SchoolEmployee(){EmployeeId=11,EmployeeName="J Imran",Email="j@gmail.com"},
            new SchoolEmployee(){EmployeeId=12,EmployeeName="K Imran",Email="k@gmail.com"},
            new SchoolEmployee(){EmployeeId=13,EmployeeName="L Imran",Email="l@gmail.com"},
            new SchoolEmployee(){EmployeeId=14,EmployeeName="M Imran",Email="m@gmail.com"},
            new SchoolEmployee(){EmployeeId=15,EmployeeName="N Imran",Email="n@gmail.com"},
            new SchoolEmployee(){EmployeeId=16,EmployeeName="O Imran",Email="o@gmail.com"},
            new SchoolEmployee(){EmployeeId=17,EmployeeName="P Imran",Email="p@gmail.com"},
            new SchoolEmployee(){EmployeeId=18,EmployeeName="Q Imran",Email="q@gmail.com"},
            new SchoolEmployee(){EmployeeId=19,EmployeeName="R Imran",Email="r@gmail.com"},
            new SchoolEmployee(){EmployeeId=20,EmployeeName="S Imran",Email="s@gmail.com"}
        };
        }

    }

   
}
