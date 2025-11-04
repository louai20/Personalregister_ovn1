using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1___Personalregister
{
    internal class Personalregister
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public void ShowAllEmployeeNames()
        {
            Console.WriteLine("\n--- Lista över anställda ---");
            foreach (var e in employees)
            {
                Console.WriteLine($"{e.firstName} {e.lastName}");
            }
        }

        public void ShowEmployeeInfo(string firstName, string lastName)
        {
            foreach (var e in employees)
            {
                if (e.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && e.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    e.DisplayEmployeeInfo();
                    return;
                }
            }
            Console.WriteLine("Ingen anställd hittades.");
        }

    }
}
