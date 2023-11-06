namespace ConsoleApp1.Models
{
	public class Employee : Person
    {
        public int Salary { get; set; }
        public string Position { get; set; }

		public override string ToString()
		{
			return $"{Id}. {Name} {Surname} {Age} {gender}";
		}


	}
}
