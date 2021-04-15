using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlCalendar.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Employee 1" });
            employees.Add(new Employee { Id = 2, Name = "Employee 2" });
            employees.Add(new Employee { Id = 3, Name = "Employee 3" });
            employees.Add(new Employee { Id = 4, Name = "Employee 4" });
            employees.Add(new Employee { Id = 5, Name = "Employee 5" });
            return employees;
        }
        
    }

    public enum Shift
    {
        Shift1,
        Shift2,
        Shift3
    }
}
