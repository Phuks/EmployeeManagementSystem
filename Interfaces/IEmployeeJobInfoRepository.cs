using EmployeeManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeJobInfoRepository : IRepositoryBase<EmployeeJobInfo>
    {
        ICollection<EmployeeJobInfo> GetEmployeesByEmployeeJobInfo(int id);
    }
}
