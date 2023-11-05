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
            foreach (var emp in employees)
            {
                if (emp.Id == Id)
                {
                    Console.WriteLine(emp.Name + " " + emp.Surname + " " + emp.Age);
                }
            }
        }
        public Employee UpGetEmployeeById(int Id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == Id)
                {
                    return emp;
                }
            }
            return null;
        }
        public void GetAllEmployee()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id}. {employee.Name} {employee.Surname} {employee.Age}");
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            Console.WriteLine("Id daxil ele: ");
            int uid = Convert.ToInt32(Console.ReadLine());

            if (employee.Id == uid)
            {
                Console.WriteLine("Surname deyis: ");
                employee.Surname = Console.ReadLine();
            }

        }
        public void RemoveEmployee(int Id)
        {
            foreach (var emp in employees)
            {
                if (Id == emp.Id)
                {
                    employees.Remove(emp);
                    return;
                }
            }
        }

    }
}
