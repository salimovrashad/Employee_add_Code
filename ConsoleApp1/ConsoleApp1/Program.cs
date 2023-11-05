namespace ConsoleApp1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Company company = new Company();
			company.Name = "Codeacademy";

			while (true) 
			{
				Console.WriteLine("Choose from below option: \n1. Create employee. \n2. Get employee details by Id. \n3. Get all employee. \n4. Remove employee. \n5.Update employee ");
				int choose = Convert.ToInt32(Console.ReadLine());
				switch (choose)
				{
					case 1:
						Employee emp = new Employee();

                        Console.WriteLine("Name: ");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Surname: ");
                        emp.Surname = Console.ReadLine();
						company.AddEmployee(emp);
						Console.WriteLine("Add employee");

						break;
					case 2:

						Console.WriteLine("Id daxil edin: ");
						int id = Convert.ToInt32(Console.ReadLine());
						company.GetEmployeeById(id);

						break;
					case 3:

						company.GetAllEmployee();
						break;

					case 4:

						Console.WriteLine("Id daxil edin: ");
						int reid = Convert.ToInt32(Console.ReadLine());

						company.RemoveEmployee(reid);
						break;

					case 5:
                        Console.WriteLine("Id daxil edin: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Employee updatedEmployee = company.UpGetEmployeeById(updateId);
                        if (updatedEmployee != null)
                        {
                            Console.WriteLine("Name: ");
                            updatedEmployee.Name = Console.ReadLine();
                            Console.WriteLine("Surname: ");
                            updatedEmployee.Surname = Console.ReadLine();
                        }
                       
                        break;
				}
			}
        }
	}
}