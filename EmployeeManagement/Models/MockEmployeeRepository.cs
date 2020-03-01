using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee{Id = 1,Name="John",Department = "ECE",Email="John@gmail.com"},
                new Employee{Id = 2,Name="Subham",Department = "CS",Email="Subham@gmail.com"},
                new Employee{Id = 3,Name="Avik",Department = "IT",Email="Avik@gmail.com"},
                new Employee{Id = 4,Name="Prasun",Department = "CS",Email="Prasun@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employees.FirstOrDefault(e => e.Id == Id);
        }
    }
}
