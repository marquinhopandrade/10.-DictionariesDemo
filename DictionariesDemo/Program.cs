using System;
using System.Collections.Generic;
namespace DictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Joe",25,35),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernerst",22,8),
            };
            Dictionary<int, string> myDictionary = new Dictionary<int, string>(){            
                { 1, "one"},            
                { 2, "two"},
                { 3, "three"},
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }
            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key) ;
            }
;
        }
    }
}
