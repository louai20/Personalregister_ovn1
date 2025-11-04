using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1___Personalregister
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public string position;

        public double salary;

        public int age;
        public DateTime birthDay;

        public Employee(string firstName, string lastName, string email, string position,
                        double salary, int age, DateTime birthDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.position = position;
            this.salary = salary;
            this.age = age;
            this.birthDay = birthDay;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Birthday: {birthDay.ToShortDateString()}");
        }
    }
}
