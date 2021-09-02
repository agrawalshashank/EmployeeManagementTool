using Entity;
using System;
using System.Collections.Generic;

namespace Service.Contract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(int id, Employee employee);
        void DeleteEmployee(int id);
    }
}
