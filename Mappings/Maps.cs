using AutoMapper;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Mappings
{
    public class Maps : Profile
    {
        public Maps()             // Constructor to create maps to exist in application
        {
            CreateMap<EmployeeJobInfo, EmployeeJobInfoVM>().ReverseMap();
            CreateMap<EmployeeHistory, EmployeeHistoryVM>().ReverseMap();
            CreateMap<EmployeeWages, EmployeeWagesVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }

    }
}
