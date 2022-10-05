using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Day_1_And_2
{
    internal class EmployeeBLL
    {
        public EmployeeDAL.IEmployeeDAL employeeDAL;

        //public EmployeeBLL(EmployeeDAL.IEmployeeDAL employeeDAL)
        //{
        //    this.employeeDAL = employeeDAL;
        //}

        //public List<Employee.employee> GetAllEmployee()
        //{
        //    return employeeDAL.GetAllEmployee();
        //}

        public List<Employee.employee> getAllEmployees(EmployeeDAL.IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.GetAllEmployee();
        }
    }
}
