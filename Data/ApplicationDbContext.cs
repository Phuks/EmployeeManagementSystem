using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobInfo> EmployeesJobInformation { get; set; }
        public DbSet<EmployeeWages> EmployeesEarnings { get; set; }
        public DbSet<EmployeeHistory> EmployeeHistories { get; set; }
        public DbSet<EmployeeManagementSystem.Models.EmployeeJobInfoVM> EmployeeJobInfoVM { get; set; }
    }
}
