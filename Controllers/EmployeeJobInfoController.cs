using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeJobInfoController : Controller
    {
        // Dependency Injection referencing one object and implying its dependencies
        private readonly IEmployeeJobInfoRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeJobInfoController(IEmployeeJobInfoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: EmployeeJobInfoController
        public ActionResult Index()
        {
            var empJobInfo = _repo.FindAll().ToList();
            var model = _mapper.Map <List<EmployeeJobInfo>, List<EmployeeJobInfoVM>>(empJobInfo);
            return View(model);
        }

        // GET: EmployeeJobInfoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeJobInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeJobInfoController/Create
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

        // GET: EmployeeJobInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeJobInfoController/Edit/5
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

        // GET: EmployeeJobInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeJobInfoController/Delete/5
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
