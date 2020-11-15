using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeJobInfo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public int EmployeeNumber { get; set; }
        public int EmployeeCount { get; set; }
        public string Department { get; set; }
        public int EnviromentSatisfaction { get; set; }
        public string JobRole { get; set; }
        public int JobInvolvement { get; set; }
        public int JobLevel { get; set; }
        public int JobSatisfaction { get; set; }
        public int PerformanceRating { get; set; }
        public int WorkLifeBalance { get; set; }
    }
}
