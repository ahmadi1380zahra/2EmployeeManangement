using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManangment
{
    static class EmployeeManangement
    {
        private static List<Employee> employees = new();
        private static int _id=0;
        public static void AddEmployee(int type,string name,int salary,string departmentName)
        {
            if (type == 1)
            {
                var employee = new Employee(name,salary, ++_id);
                employees.Add(employee);
                employee.PrintDetail(employee.Name,employee.ID,employee.Salary);
             }
            if (type == 2)
            {
                var manager = new Manager(name, salary,++ _id, departmentName);
                employees.Add(manager);
                manager.PrintDetail(manager.Name, manager.ID, manager.Salary);
            }
        }
        
    }
}
