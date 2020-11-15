using EmployeeManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeWagesRepository : IRepositoryBase<EmployeeWages>
    {
        ICollection<EmployeeWages> GetEmployeesByEmployeeWages(int id);
    }
}
