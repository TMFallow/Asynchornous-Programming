// See https://aka.ms/new-console-template for more information
using Demo_Day_1_And_2;

//EmployeeBLL employeeBLL = new EmployeeBLL(new EmployeeDAL.employeeDAL());

//List<Employee.employee> list = employeeBLL.GetAllEmployee();

EmployeeBLL employeeBLL = new EmployeeBLL();
List<Employee.employee> list = employeeBLL.getAllEmployees(new EmployeeDAL.employeeDAL()); 

foreach(Employee.employee prs in list)
{
    Console.WriteLine("Id = {0}, Name = {1}, Age = {2}, Department = {3}", prs.Id, prs.Name, prs.Age, prs.Department);
}
Console.ReadKey();
