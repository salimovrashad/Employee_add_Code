﻿namespace ConsoleApp1.Models
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
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual void Fullname() { }
    }

    
}