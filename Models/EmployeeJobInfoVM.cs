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
        [Required]
        [Display(Name = "Emp_Num")]
        public int EmployeeNumber { get; set; }
        [Required]
        [Display(Name = "Emp_Count")]
        public int EmployeeCount { get; set; }
        [Required]
        public string Department { get; set; }
        /*[Required]
        [Display(Name = "Enviroment_Satisfaction")]
        public int EnviromentSatisfaction { get; set; }*/
        [Required]
        [Display(Name = "Job_Role")]
        public string JobRole { get; set; }
        [Required]
        [Display(Name = "Job_Involvemnet")]
        public int JobInvolvement { get; set; }
        [Required]
        [Display(Name = "Job_Level")]
        public int JobLevel { get; set; }
        [Required]
        [Display(Name = "Job_Satisfaction")]
        public int JobSatisfaction { get; set; }
        /*[Required]
        [Display(Name = "Performance_Rating")]
        public int PerformanceRating { get; set; }
        [Required]
        [Display(Name = "Work_Life_Balance")]
        public int WorkLifeBalance { get; set; }*/
    }

}
