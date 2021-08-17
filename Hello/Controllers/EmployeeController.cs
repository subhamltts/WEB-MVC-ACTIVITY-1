using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello.Controllers
{
    public class EmployeeController : Controller
    {
        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public List<Models.Employee> GetEmployees()
            {
                List<Models.Employee> lst = new List<Models.Employee>();
                lst.Add(new Models.Employee { EmpID = 1, EmpName = "Subham" });
                lst.Add(new Models.Employee { EmpID = 2, EmpName = "Kumar" });
                lst.Add(new Models.Employee { EmpID = 3, EmpName = "Ajay" });
                lst.Add(new Models.Employee { EmpID = 4, EmpName = "Rahul" });
                return lst;
            }
        }
        // GET: Employee
        public ActionResult Index()
        {
            Employee obj = new Employee();
            var result = obj.GetEmployees();
            return View(result);
        }

        // GET: Employee/Details/5
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
