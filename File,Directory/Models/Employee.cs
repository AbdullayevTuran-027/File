using System;
using System.Collections.Generic;
using System.Text;

namespace File_Directory.Models
{
    internal class Employee
    {
        public int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name)
        {
            _id++;
            Id = Id;
            Name = name;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}Name: {Name}Salary: {Salary}");
        }

    }
}
