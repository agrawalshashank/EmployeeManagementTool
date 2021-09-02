using Entity;
using Persistence.Contract;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryBase<Employee> _repository;

        public EmployeeService(IRepositoryBase<Employee> repository)
        {
            _repository = repository;
        }

        public void CreateEmployee(Employee employee)
        {
            _repository.Create(employee);
        }

        public void DeleteEmployee(int id)
        {
            _repository.Delete(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAll().ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            _repository.Update(id, employee);
        }
    }
}
