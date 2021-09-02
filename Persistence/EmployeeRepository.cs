using Entity;
using Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence
{
    public class EmployeeRepository : IRepositoryBase<Employee>
    {
        EmployeeContext dbContext;
        public EmployeeRepository()
        {
            dbContext = new EmployeeContext();
        }

        public void Create(Employee entity)
        {
            dbContext.AddAsync(entity);
            dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            dbContext.Remove(GetById(id));
            dbContext.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAll()
        {
            dbContext = new EmployeeContext();
            return dbContext.Employee.AsQueryable().ToList();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee entity)
        {
            var changeEntity = dbContext.Update(entity);
            dbContext.SaveChangesAsync();
            return changeEntity.Entity;
        }
    }
}
