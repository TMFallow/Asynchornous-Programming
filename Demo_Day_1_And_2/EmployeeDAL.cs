using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Day_1_And_2
{
    internal class EmployeeDAL
    {
        public interface IEmployeeDAL
        {
            List<Employee.employee> GetAllEmployee();
        }

        public class employeeDAL : IEmployeeDAL
        {
            public List<Employee.employee> GetAllEmployee()
            {
                List<Employee.employee> list = new List<Employee.employee>();
                list.Add(new Employee.employee() { Id = 1, Name = "Phan Thanh Binh", Age = 20, Department = "IT" });
                list.Add(new Employee.employee() { Id = 2, Name = "Le Thi Thanh Thuy", Age = 20, Department = "IT" });
                list.Add(new Employee.employee() { Id = 3, Name = "Pham Tuan Dat", Age = 20, Department = "IT" });
                list.Add(new Employee.employee() { Id = 4, Name = "Ho Duc Duy", Age = 20, Department = "IT" });
                return list;
            }
        }
    }
}
