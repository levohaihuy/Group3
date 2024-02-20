using System;
using baitap1.obj;
using System.Collections.Generic;


namespace baitap1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            int choice;

            do
            {
                Console.WriteLine("----- EMPLOYEE MANAGEMENT -----");
                Console.WriteLine("1. Add new employee.");
                Console.WriteLine("2. Shows all employees.");
                Console.WriteLine("3. Quit");
                Console.Write("Please select a function: ");
                Employee e = new Employee();
                
               
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                   
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Input ID: ");
                            e.ID = Console.ReadLine();
                            Console.Write("Input name: ");
                            e.FullName = Console.ReadLine();
                            Console.Write("Input year of birth: ");
                            e.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input salary: ");
                            e.Salary = Convert.ToInt32(Console.ReadLine());
                            employees.Add(e);
                            Console.WriteLine("Employee created and added to list of employee successfull!");
                            break;
                        case 2:
                            Console.WriteLine("----- List of employee -----");
                            Console.WriteLine("-No.   -- ID  -- Employee name -- Year Of Birth -- Salary -");
                            Employee hightSalary = employees[0];
                            int currentYear = DateTime.Now.Year;
                            int index = 0;
                            for (int i = 0; i < employees.Count; i++)
                            {
                                if (employees[i].Salary > hightSalary.Salary)
                                {
                                    hightSalary = employees[i];
                                    index = i;
                                }
                                Console.WriteLine($"-{i + 1}   -- {employees[i].ID}  -- {employees[i].FullName} -- {employees[i].YearOfBirth} -- {employees[i].Salary} -");
                            }
                                Console.WriteLine($"*The employee who has the highest salary: {employees[index].FullName} ({currentYear - employees[index].YearOfBirth}, Salary: {employees[index].Salary}$) ");
                            break;
                        case 3:
                            Console.WriteLine("Bạn đã chọn lựa chọn 3.");
                            choice = 0;
                            break;
                        case 0:
                            Console.WriteLine("Chương trình kết thúc.");
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập lại.");
                }

                Console.WriteLine(); // In một dòng trắng để tạo định dạng cho menu
            } while (choice != 0);

        }
    }
}


