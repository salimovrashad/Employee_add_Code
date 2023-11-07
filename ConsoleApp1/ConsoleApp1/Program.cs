using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class Program
	{
		static void Main(string[] args)
		{
			while (true) 
			{
				Console.WriteLine("Choose from below option: \n1. Create employee. \n2. Get employee details by Id. \n3. Get all employee. \n4. Remove employee. \n5. Update employee ");
				int choose = Convert.ToInt32(Console.ReadLine());
				switch (choose)
				{
					case 1:
						
						Employee emp = new Employee();

                        Console.WriteLine("Name: ");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Surname: ");
                        emp.Surname = Console.ReadLine();
                        Console.WriteLine("Age: ");
						emp.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Gender: ");
						emp.gender = (Gender)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("DateTime: (yyyy-MM-dd HH:mm:ss)");
						emp.CreatedAt = DateTime.Parse(Console.ReadLine());
                        EmployeeServices.AddEmployee(emp);
						Console.WriteLine("Add employee");
						break;
					case 2:

						Console.WriteLine("Id daxil edin: ");
						int id = Convert.ToInt32(Console.ReadLine());
						EmployeeServices.GetEmployeeById(id);
						break;
					case 3:

						EmployeeServices.GetAllEmployee();
						break;

					case 4:

						Console.WriteLine("Id daxil edin: ");
						int reid = Convert.ToInt32(Console.ReadLine());

						EmployeeServices.RemoveEmployee(reid);
						break;

					case 5:
                        Console.WriteLine("Id daxil edin: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Employee updatedEmployee = EmployeeServices.UpGetEmployeeById(updateId);
                        if (updatedEmployee != null)
                        {
                            Console.WriteLine("Name: ");
                            updatedEmployee.Name = Console.ReadLine();
                            Console.WriteLine("Surname: ");
                            updatedEmployee.Surname = Console.ReadLine();
                            Console.WriteLine("Age: ");
							updatedEmployee.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Gender: ");
							updatedEmployee.gender = (Gender)Convert.ToInt32(Console.ReadLine());
						}
                        break;
					case 6:
						EmployeeServices.GetLatestEmployees();
						break;
					case 7:
						EmployeeServices.GetEmployeeByValue(Console.ReadLine());
						break;
				}
			}
        }
	}
}