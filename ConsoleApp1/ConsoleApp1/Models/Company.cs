namespace ConsoleApp1.Models
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
            foreach (var item in employees.FindAll(p => p.Id == Id))Console.WriteLine(item);
        }
        public Employee UpGetEmployeeById(int Id)
        {
			var delegat = employees.FindAll(p => p.Id == Id);
			foreach (var item in delegat)
			{
				return item;
			}
			return null;
        }
        public void GetAllEmployee()
        {
			employees.ForEach(delegate (Employee employee) {
				Console.WriteLine(employee);
			});
		}
        public void RemoveEmployee(int Id)
        {
			foreach (var item in employees.FindAll(p => p.Id == Id)) employees.Remove(item);
		}

    }
}
