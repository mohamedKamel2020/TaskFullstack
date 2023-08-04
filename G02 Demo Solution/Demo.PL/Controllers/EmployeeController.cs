using AutoMapper;
using Demo.BLL.Interface;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index(string SearchValue)
        {
            IEnumerable<Employee> employees = Enumerable.Empty<Employee>();
            if(string.IsNullOrEmpty(SearchValue))
				employees = _unitOfWork.EmployeeRepository.GetAll();
            else
                employees = _unitOfWork.EmployeeRepository.SearchEmployeeByName(SearchValue);


			var mappedEmps=_mapper.Map<IEnumerable<Employee>,IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEmps);
        }
        public IActionResult Create()
        {
            ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                _unitOfWork.EmployeeRepository.Add(mappedEmp);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }
        public IActionResult Details(int? id, string viewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = _unitOfWork.EmployeeRepository.Get(id.Value);
            if (employee == null)
                return NotFound();
            var mappedEmployee=_mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(viewName, mappedEmployee);
        }
        public IActionResult Edit(int? id)
        {
            return Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Update(mappedEmployee);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // 1.Log Exception
                    // 2.Frindly Message
                    ModelState.AddModelError(string.Empty, ex.Message); // 3.NotFrindly Message
					return View(employeeVM);
				}
            }
            return View(employeeVM);
        }
        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");
        }
        [HttpPost]
        public IActionResult Delete([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                _unitOfWork.EmployeeRepository.Delete(mappedEmployee);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
				return View(employeeVM);
			}
 
        }

    }
}
