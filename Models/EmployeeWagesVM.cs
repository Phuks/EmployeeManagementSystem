using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeWagesVM
    {
        public int Id { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public EmployeeJobInfoVM EmployeeJobInfo { get; set; }
        public int EmployeeJobInfoId { get; set; }
        [Required]
        public int MonthlyIncome { get; set; }
        [Required]
        public int MonthlyRate { get; set; }
        [Required]
        public int DailyRate { get; set; }
        [Required]
        public int HourlyRate { get; set; }
        [Required]
        public int StandardHours { get; set; }
        [Required]
        public string Overtime { get; set; }
        [Required]
        public int PercentSalaryHike { get; set; }
       
        /*public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> EmployeesJobInfo { get; set; }*/
    }

    public class CreateEmployeeWagesVM
    {
        public int NumberUpdated { get; set; }
        public List<EmployeeJobInfoVM> EmployeeJobInfos { get; set; }
    }

    public class ViewEmployeeWagesVM
    {
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public List<EmployeeWagesVM> EmployeeWages { get; set; }
    }

}
