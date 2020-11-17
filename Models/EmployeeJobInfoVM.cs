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
        [Display(Name = "Emp_Id")]
        public string RequestingEmployeeId { get; set; }
        [Display(Name = "Emp_Num")]
        public int EmployeeNumber { get; set; }
        [Display(Name = "Emp_Count")]
        public int EmployeeCount { get; set; }
        public string Department { get; set; }
        [Display(Name = "Enviroment_Satisfaction")]
        public int EnviromentSatisfaction { get; set; }
        [Display(Name = "Job_Role")]
        public string JobRole { get; set; }
        [Display(Name = "Job_Involvemnet")]
        public int JobInvolvement { get; set; }
        [Display(Name = "Job_Level")]
        public int JobLevel { get; set; }
        [Display(Name = "Job_Satisfaction")]
        public int JobSatisfaction { get; set; }
        [Display(Name = "Performance_Rating")]
        public int PerformanceRating { get; set; }
        [Display(Name = "Work_Life_Balance")]
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
