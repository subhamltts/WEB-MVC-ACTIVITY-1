using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class EmployeeController : Controller
    {
        public class Employee
        {
            public int EmpID { get; set; }
            public string Empname { get; set; }
            public List<Models.Employee> GetEmployees()
            {
                List<Models.Employee> lst = new List<Models.Employee>();
                lst.Add(new Models.Employee { EmpID = 100, EmpName = "Subham" });
                lst.Add(new Models.Employee { EmpID = 101, EmpName = "Kumar" });
                return lst;
            }
        }
        // GET: Employee
        public ActionResult Index()
        {
            Employee objnew = new Employee();
            var result = objnew.GetEmployees();
            return View(result);
        }

        // GET: Employee/Details
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
