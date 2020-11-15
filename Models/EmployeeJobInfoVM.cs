using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeJobInfoVM
    {
        public int Id { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
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

    public class CreateEmployeeJobInfoVM
    {
        [Required]
        public int EmployeeNumber { get; set; }
        [Required]
        public int EmployeeCount { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int EnviromentSatisfaction { get; set; }
        [Required]
        public string JobRole { get; set; }
        [Required]
        public int JobInvolvement { get; set; }
        [Required]
        public int JobLevel { get; set; }
        [Required]
        public int JobSatisfaction { get; set; }
        [Required]
        public int PerformanceRating { get; set; }
        [Required]
        public int WorkLifeBalance { get; set; }
    }


}
