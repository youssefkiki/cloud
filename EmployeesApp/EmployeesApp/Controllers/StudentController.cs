using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesApp.Models;

namespace EmployeesApp.Controllers
{
    public class StudentController : Controller
    {
        DatebaseContext dbContext = new DatebaseContext();

        public IActionResult Index()
        {
            List<Student> students = dbContext.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            ModelState.Remove("Studentid");
            ModelState.Remove("Department");
            ModelState.Remove("DepartmentName");

            if (ModelState.IsValid)
            {
                dbContext.Students.Add(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View();
        }

        public IActionResult Edit(int ID)
        {
            Student data = this.dbContext.Students.Where(e => e.StudentId == ID).FirstOrDefault();
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View("Create", data);
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            ModelState.Remove("Studentid");
            ModelState.Remove("Department");
            ModelState.Remove("DepartmentName");

            if (ModelState.IsValid)
            {
                dbContext.Students.Update(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View("Create", model);

        }
        [HttpPost]
        public IActionResult Delete(int ID)
        {
            Student data = this.dbContext.Students.Where(e => e.StudentId == ID).FirstOrDefault();
            if(data != null)
            {
                dbContext.Students.Remove(data);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
