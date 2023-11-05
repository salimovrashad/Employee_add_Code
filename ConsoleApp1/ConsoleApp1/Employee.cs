using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Employee : Person
	{
        public int Salary { get; set; }
		public string Position { get; set; }
		public enum Gender 
		{
			Male,
			Female,
		}

        
    }
}
