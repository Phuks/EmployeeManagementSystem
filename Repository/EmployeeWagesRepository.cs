using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public bool CheckAllocation(int empjobinfoid, string employeeid)
        {
            var monthlyincome = int.MaxValue;
            return FindAll()
                .Where(q => q.EmployeeId == employeeid && q.EmployeeJobInfoId == empjobinfoid && q.MonthlyIncome == monthlyincome)
                .Any();
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
            var empWages = _db.EmployeesEarnings.Include(q => q.EmployeeJobInfo).ToList();
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

        public ICollection<EmployeeWages> GetEmployeeWagesByEmployee(string id)
        {
            var monthlyincome = int.MaxValue;
            return FindAll()
                .Where(q => q.EmployeeId == id && q.MonthlyIncome == monthlyincome)
                .ToList();
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
