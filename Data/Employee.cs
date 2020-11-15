using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class Employee : IdentityUser
    {
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
