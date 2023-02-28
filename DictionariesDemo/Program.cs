using System;
using System.Collections.Generic;
using System.Linq;

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
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()  {            
                { 1, "one"},            
                { 2, "two"},
                { 3, "three"},
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            //UPDATE
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }
            else
            {
                //if no, print an error message
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }
            //REMOVE
            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!.", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No employees found with this Key {0}", KeyToRemove);
            }
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("Type your role in the enterprise:");
            string key = Convert.ToString(Console.ReadLine());
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }
            //using TryGetValue() it returns true if the operation was successful and false otherwise
            /*
            Employee result = null;
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!.");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }
            */
        }
    }
}
