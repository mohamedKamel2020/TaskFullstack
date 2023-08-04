using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Demo.BLL.Interface;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly IMapper _mapper;
        public DepartmentController(IDepartmentRepository departmentRepository,IMapper mapper)
        {
			_departmentRepository = departmentRepository;
			_mapper = mapper;
        }
        public IActionResult Index(string SearchValue)
		{
			ViewData["Message"] = "Hello Department";
			ViewBag.Message = "Hello Department";
			IEnumerable<Department> departments = Enumerable.Empty<Department>();
			if (string.IsNullOrEmpty(SearchValue))
				departments = _departmentRepository.GetAll();
			else
				departments = _departmentRepository.SearchEmployeeByName(SearchValue);

            var mappedDeps = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDeps);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(DepartmentViewModel departmentVM)
		{
			if (ModelState.IsValid)
			{
				var mappedDepartment=_mapper.Map<DepartmentViewModel,Department>(departmentVM);
				_departmentRepository.Add(mappedDepartment);
				TempData["Message"] = "Department is Created Successfully";
				return RedirectToAction(nameof(Index));
			}
			return View(departmentVM);
		}
		public IActionResult Details(int? id,string viewName="Details")
		{
			if (id == null)
				return NotFound();
			var department = _departmentRepository.Get(id.Value);
			if(department == null)
				return NotFound();
			var mappedDep=_mapper.Map<Department,DepartmentViewModel>(department);
			return View(viewName, mappedDep);
		}
		public IActionResult Edit(int? id) 
		{
			return Details(id, "Edit");
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit([FromRoute]int id,DepartmentViewModel departmentVM)
		{
			if(id !=departmentVM.Id)
				return BadRequest();
			if (ModelState.IsValid)
			{
				try
				{
					var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
					_departmentRepository.Update(mappedDepartment);
					return RedirectToAction(nameof(Index));
				}
				catch(Exception ex)
				{
					// 1.Log Exception
					// 2.Frindly Message
					ModelState.AddModelError(string.Empty, ex.Message); // 3.NotFrindly Message
                    return View(departmentVM);
                }	
			}
            return View(departmentVM);
        }
		public IActionResult Delete(int? id) 
		{
			return Details(id, "Delete");
		}
		[HttpPost]
		public IActionResult Delete([FromRoute]int id,DepartmentViewModel departmentVM) 
		{
			if (id !=departmentVM.Id)
				return BadRequest();
			try
			{
                var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                _departmentRepository.Delete(mappedDepartment);
				return RedirectToAction(nameof(Index));
			}catch(Exception ex) {
				ModelState.AddModelError(string.Empty,ex.Message);
                return View(departmentVM);
            }	
		}

	}
}
