using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Attrition { get; set; }
        public string Gender { get; set; }
        public char Over18 { get; set; }
        public string MaritalStatus { get; set; }
        public int Education { get; set; }
        public string EducationField { get; set; }
        public string BusinessTravel { get; set; }
        public int DistanceFromHome { get; set; }
    }

}
