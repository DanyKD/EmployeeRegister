using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeRegister.Models;

namespace EmployeeRegister.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeRegisterContext db = new EmployeeRegisterContext();

        // GET: Employees
        public ActionResult Index(string searchString)
        {
            var model = db.Employees.OrderBy(s => s.FirstName).ToList();
            var searchdb = from m in db.Employees select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchdb = searchdb.Where(s => s.FirstName.Contains(searchString)|| s.LastName.Contains(searchString));
            }

            return View(searchdb);
        }
        //Get: Sort By Salary
        public ActionResult SortBySalary(string sortBy)
        {
            var SalaryDb = db.Employees.AsQueryable();
            ViewBag.SortSalaryParameter = string.IsNullOrEmpty(sortBy) ? "Salary desc" : "";
            ViewBag.SortDepartmentParameter = sortBy == "Department" ? "Department desc" : "Department";
            ViewBag.SortFirstNameParameter = sortBy == "FirstName" ? "FirstName desc" : "FirstName";

            switch (sortBy)
            {
                case "Salary desc":
                SalaryDb = SalaryDb.OrderByDescending(x => x.Salary);
                    break;
                case "Department":
                    SalaryDb = SalaryDb.OrderBy(x => x.Department);
                    break;
                case "Department desc":
                    SalaryDb = SalaryDb.OrderByDescending(x => x.Department);
                    break;
                case "FirstName desc":
                    SalaryDb = SalaryDb.OrderByDescending(x => x.FirstName);
                    break;
                case "FirstName":
                    SalaryDb = SalaryDb.OrderBy(x => x.FirstName);
                    break;
                default:
                    SalaryDb = SalaryDb.OrderBy(x => x.Salary);
                    break;
             }            
            return View(SalaryDb.ToList());
        }        

        public ActionResult Sport()
        {
            var model = db.Employees.Where(i => i.Department== Department.Sport).ToList();

            return View(model);
        }

        public ActionResult Managers()
        {
            var model = db.Employees.Where(i => i.Position == "Manager").ToList();

            return View(model);
        }

        public ActionResult Sales()
        {
            var model = db.Employees.Where(i => i.Department == Department.Sales).ToList();

            return View(model);
        }


        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Salary,Position,Department,PersonalNumber,BirthDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,BirthDate,Salary,Position,Department")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
