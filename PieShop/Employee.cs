using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PieShop
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minHoursWorked = 1;

        public Employee(string first, string last, string em, double rate, DateTime db)
        { 
            firstName = first;
            lastName = last;
            email = em;
            hourlyRate = rate;
            birthDay = db;
        }

        public Employee(string first, string last, string em, DateTime db) : this(first, last, em, 0, db)
        {}
        public void PerformWork()
        {
            PerformWork(minHoursWorked);
        }

        public void PerformWork(int numOfHours)
        {
            numberOfHoursWorked+=numOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked}");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received the sum of {wage}");

            if(resetHours )
                numberOfHoursWorked = 0;

            return wage;

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\n{firstName}\n{lastName}\n{email}\n{birthDay}");
        }
    }
}
