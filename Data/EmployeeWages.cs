using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeWages
    {
        [Key]
        public int Id { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public int DailyRate { get; set; }
        public int HourlyRate { get; set; }
        public string Overtime { get; set; }
        public int PercentSalaryHike { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        [ForeignKey("EmployeeJobInfoId")]
        public EmployeeJobInfo EmployeeJobInfo { get; set; }
        public int EmployeeJobInfoId { get; set; }
    }

}
