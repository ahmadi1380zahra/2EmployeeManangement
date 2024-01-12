using System;

namespace EmployeeManangment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            static void Run()
            {
                var option = GetInt("1.add employee");
                switch (option)
                {
                    case 1:
                        {
                            string department=null;
                            var name = GetString("Enter Employe Name");
                            var salary = GetInt("Enter Employe salary");
                            var employeType = GetInt("1.simple employee 2.manager");
                            if (employeType != 2 & employeType != 1)
                            {
                                throw new Exception("No valid Type");
                            }
                            if (employeType == 2)
                            {
                                 department = GetString("Enter department Name");
                            }
                           
                            EmployeeManangement.AddEmployee(employeType,name,salary,department);
                            break;
                        }

                }
            }

        }
        static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;
        }

        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }
    }
}
