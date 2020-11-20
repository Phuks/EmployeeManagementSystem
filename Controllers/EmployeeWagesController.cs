using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]                 // Authorizing only Admin users that are logged in to avoid maliciousness
    public class EmployeeWagesController : Controller
    {
        // Dependency Injection referencing one object and implying its dependencies
        private readonly IEmployeeJobInfoRepository _empjobinforepo;
        private readonly IEmployeeWagesRepository _empwagesrepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;

        public EmployeeWagesController(
            IEmployeeJobInfoRepository empjobinforepo,
            IEmployeeWagesRepository empwagesrepo,
            IMapper mapper,
            UserManager<Employee> userManager
        )
        {
            _empjobinforepo = empjobinforepo;
            _empwagesrepo = empwagesrepo;
            _mapper = mapper;
            _userManager = userManager;
        }


        // GET: EmployeeWagesController
        public ActionResult Index()
        {
            var empJobInfo = _empjobinforepo.FindAll().ToList();
            var mappedEmployeeJobInfo = _mapper.Map<List<EmployeeJobInfo>, List<EmployeeJobInfoVM>>(empJobInfo); //Loading the model to be a list of EmployeeJobInfo
            var model = new CreateEmployeeWagesVM
            {
                EmployeeJobInfos = mappedEmployeeJobInfo,
                NumberUpdated = 0
            };
            return View(model);
        }

        // Creating a custom action
        public ActionResult SetWage(int id)
        {
            var empjobinfo = _empjobinforepo.FindById(id);
            var employees = _userManager.GetUsersInRoleAsync("Employee").Result;
            foreach (var emp in employees)
            {
                if (_empwagesrepo.CheckAllocation(id, emp.Id))
                    continue;
                
                var allocation = new EmployeeWagesVM
                {
                   EmployeeId = emp.Id,
                   EmployeeJobInfoId = id,
                   MonthlyIncome = int.MaxValue,
                   DailyRate = int.MaxValue,
                   HourlyRate = int.MaxValue,
                   Overtime = string.Empty,
                   PercentSalaryHike = int.MaxValue
                    
                };
                var empwages = _mapper.Map<EmployeeWages>(allocation);
                _empwagesrepo.Create(empwages);
            }
            return RedirectToAction(nameof(Index));
        }

        // Custom Action
        public ActionResult ListEmployees()
        {
            var employees = _userManager.GetUsersInRoleAsync("Employee").Result;    // Query for all the employees
            var model = _mapper.Map<List<EmployeeVM>>(employees);                   // Map them to the VMs 
            return View(model);
        }

        // GET: EmployeeWagesController/Details/5
        public ActionResult Details(string id)
        {
            var employee = _mapper.Map<EmployeeVM>(_userManager.FindByIdAsync(id).Result); //Get emp and do the mapping
            var allocations = _mapper.Map<List<EmployeeWagesVM>>(_empwagesrepo.GetEmployeeWagesByEmployee(id));

            var model = new ViewEmployeeWagesVM
            {

                Employee = employee,
                EmployeeWages = allocations
            };
            return View(model);
        }

        // GET: EmployeeWagesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeWagesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeWagesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeWagesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeWagesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeWagesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
