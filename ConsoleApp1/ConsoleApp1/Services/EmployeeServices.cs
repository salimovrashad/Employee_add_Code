using ConsoleApp1.Database;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
	public static class EmployeeServices
	{
		public static void AddEmployee(Employee employee)
		{
			EmployeeDatabase.employees.Add(employee);
		}
		public static void GetEmployeeById(int Id)
		{
			foreach (var item in EmployeeDatabase.employees.FindAll(p => p.Id == Id)) Console.WriteLine(item);
		}

		public static void GetEmployeeByValue(string value) 
		{
			foreach (var item in EmployeeDatabase.employees.FindAll(p => p.Name.Contains(value))) Console.WriteLine(item);
		}

		public static Employee UpGetEmployeeById(int Id)
		{
			var delegat = EmployeeDatabase.employees.FindAll(p => p.Id == Id);
			foreach (var item in delegat)
			{
				return item;
			}
			return null;
		}
		public static void GetAllEmployee()
		{
			EmployeeDatabase.employees.ForEach(delegate (Employee employee) {
				Console.WriteLine(employee);
			});
		}
		public static void RemoveEmployee(int Id)
		{
			foreach (var item in EmployeeDatabase.employees.FindAll(p => p.Id == Id)) EmployeeDatabase.employees.Remove(item);
		}

		public static void GetLatestEmployees() 
		{
			foreach (var item in EmployeeDatabase.employees.FindAll(p => DateTime.Now.Day -  p.CreatedAt.Day <= 7 )) Console.WriteLine(item);
		}
	}
}
