using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Company : Employee
	{
        public string Name { get; set; }
		List<Employee> employees = new List<Employee>();

		public void AddEmployee(Employee employee) 
		{
			employees.Add(employee);
		}
		public void GetEmployeeById(int Id) 
		{
            foreach (var emp in employees)
            {
                if (emp.Id == Id)
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
		public void GetAllEmployee() 
		{
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id}. {employee.Name} {employee.Surname}");
            }
        }
		public void UpdateEmployee(Employee employee) 
		{
			employee.Name = "SADSADS";
		}
		public void RemoveEmployee(int Id)
		{
            foreach (var emp in employees)
            {
				if (Id == emp.Id)
				{
					employees.Remove(emp);
					return ;
				}
			}
        }

	}
}
