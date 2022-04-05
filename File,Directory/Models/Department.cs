using System;
using System.Collections.Generic;
using System.Text;

namespace File_Directory.Models
{
    internal class Department
    {
        public int _id; 
        public int Id { get; }
        public string Name { get; set; }
        List<Employee> employee;

        public Department(string name)
        {
            _id++;
            Id = _id;
            Name = name;
            employee = new List<Employee>();
        }
        public void AddEmployee(Employee employe)
        {
           employee.Add(employe);
        }
        public Employee GetEmployeeById(int id)
        {
            return employee.Find(m => m.Id == id);  
        }
        public List<Employee> RemoveEmployee(int id)
        {
           
            
        }
    }
}
