using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Person
	{
		private static int _id = -1;
		public int Id;
		public Person()
		{
			_id++;
			Id = _id;
		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
			
		public virtual void Fullname() { }
    }
}