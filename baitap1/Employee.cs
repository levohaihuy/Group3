using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap1.obj
{
    public class Employee

    {

        private string id;
        private string fullName;
        private int yearOfBirth;
        private int salary;
        DateTime currentDate = DateTime.Now;
        public String ID
        {
            get { return id; }
            set { 
                 while (value == "")
                {
                    Console.WriteLine("ID cannot be empty!"); 
                    Console.WriteLine("Enter a non-empty ID:");
                    value = Console.ReadLine(); 
                }

                id = value;
                }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                while (string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit) && !value.Any(char.IsSymbol))
                {
                    Console.WriteLine("Invalid name. Please re-enter.");
                    Console.WriteLine("Enter a Fullname:");
                    value = Console.ReadLine();
                }
                fullName = value;
            }
        }

        public int YearOfBirth
        {
            get { return yearOfBirth; }
            set
            {
                // Assuming a reasonable range, for example, from 1900 to the current year
                if (!int.TryParse(value.ToString(), out int result) || value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Invalid year of birth");
                }

                yearOfBirth = value;
            }

        }

        public int Salary
        {
            get { return salary; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Salary must be greater than 0. Please input again!");
                    Console.Write("Input salary: ");
                    
                    value = Convert.ToInt32(Console.ReadLine());
                }
                
                salary = value;
            }
        }
     }
}