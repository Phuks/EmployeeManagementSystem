using EmployeeManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeHistoryRepository : IRepositoryBase<EmployeeHistory>
    {
        ICollection<EmployeeHistory> GetEmployeesByEmployeeHistory(int id);
    }
}
