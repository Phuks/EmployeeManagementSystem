using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeJobInfoRepository : IEmployeeJobInfoRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeJobInfoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(EmployeeJobInfo entity)
        {
            _db.EmployeesJobInformation.Add(entity);
            return Save();
        }

        public bool Delete(EmployeeJobInfo entity)
        {
            _db.EmployeesJobInformation.Remove(entity);
            return Save();
        }

        public ICollection<EmployeeJobInfo> FindAll()
        {
            return _db.EmployeesJobInformation.ToList();
        }

        public EmployeeJobInfo FindById(int id)
        {
            var empJobInfo = _db.EmployeesJobInformation.Find(id);
            return empJobInfo;
        }

        public ICollection<EmployeeJobInfo> GetEmployeesByEmployeeJobInfo(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.EmployeesJobInformation.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()              //Returns how many records have beeb edited
        {
           var changes = _db.SaveChanges();
            return changes > 0;

        }

        public bool Update(EmployeeJobInfo entity)
        {
            _db.EmployeesJobInformation.Update(entity);
            return Save();
        }
    }
}
