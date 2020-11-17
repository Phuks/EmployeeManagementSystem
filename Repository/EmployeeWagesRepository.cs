using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeWagesRepository : IEmployeeWagesRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeWagesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(EmployeeWages entity)
        {
            _db.EmployeesEarnings.Add(entity);
            return Save();
        }

        public bool Delete(EmployeeWages entity)
        {
            _db.EmployeesEarnings.Remove(entity);
            return Save();
        }

        public ICollection<EmployeeWages> FindAll()
        {
            var empWages = _db.EmployeesEarnings.ToList();
            return empWages;
        }

        public EmployeeWages FindById(int id)
        {
            var empWages = _db.EmployeesEarnings.Find();
            return empWages;
        }

        public ICollection<EmployeeWages> GetEmployeesByEmployeeWages(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.EmployeesEarnings.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(EmployeeWages entity)
        {
            _db.EmployeesEarnings.Update(entity);
            return Save();
        }
    }
}
