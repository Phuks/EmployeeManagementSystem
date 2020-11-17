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
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var empJobInfo = _repo.FindById(id);
            var model = _mapper.Map<EmployeeJobInfoVM>(empJobInfo);
            return View(model);
        }

        // GET: EmployeeJobInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeJobInfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeJobInfoVM model)
        {
            try
            {
                // TODO: Adding insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var empJobInfo = _mapper.Map<EmployeeJobInfo>(model);

                var isSuccess = _repo.Create(empJobInfo);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "There is a fault somewhere...");
                    return View(model);
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "There is a fault somewhere...");
                return View(model);
            }
        }

        // GET: EmployeeJobInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var empJobInfo = _repo.FindById(id);
            var model = _mapper.Map<EmployeeJobInfoVM>(empJobInfo);
            return View(model);
        }

        // POST: EmployeeJobInfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeJobInfoVM model)
        {
            try
            {
                // TODO: Adding update logic here
                if (!ModelState.IsValid)                // Validating the data
                {
                    return View(model);
                }
                var empJobInfo = _mapper.Map<EmployeeJobInfo>(model);           // Mapping from ViewModel to Data class and storing in variable
                var isSuccess = _repo.Update(empJobInfo);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "There is a fault somewhere...");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "There is a fault somewhere...");
                return View(model);
            }
        }

        // GET: EmployeeJobInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            /*if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var empJobInfo = _repo.FindById(id);
            var model = _mapper.Map<EmployeeJobInfoVM>(empJobInfo);
            return View(model);*/

            var empJobInfo = _repo.FindById(id);

            if (empJobInfo == null)
            {
                return NotFound();
            }

            var isSuccess = _repo.Delete(empJobInfo);

            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: EmployeeJobInfoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EmployeeJobInfoVM model)
        {
            try
            {
                // TODO: Adding delete logic here
                var empJobInfo = _repo.FindById(id);

                if (empJobInfo == null)
                {
                    return NotFound();
                }

                var isSuccess = _repo.Delete(empJobInfo);

                if (!isSuccess)
                {
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
