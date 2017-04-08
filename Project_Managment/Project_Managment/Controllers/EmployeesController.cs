﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_Managment.Models;

namespace Project_Managment.Controllers
{
    public class EmployeesController : Controller
    {
        private AccessDbContext db = new AccessDbContext();

        // GET: Employees1
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department).OrderBy(e => e.FirstName).ToList(); ;
            return View(employees.ToList());
        }

        // GET: Employees1/Details/5
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

        // GET: Employees1/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName");
            ViewBag.EmployeeID = new SelectList(db.Employee_Assets, "Employee_AssetID", "Employee_AssetID");
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName");
            return View();
        }

        // POST: Employees1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,DepartmentID,FirstName,LastName,OfficeLocation,GroupID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName", employee.DepartmentID);
            ViewBag.EmployeeID = new SelectList(db.Employee_Assets, "Employee_AssetID", "Employee_AssetID", employee.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", employee.GroupID);
            return View(employee);
        }

        // GET: Employees1/Edit/5
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
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName", employee.DepartmentID);
            ViewBag.EmployeeID = new SelectList(db.Employee_Assets, "Employee_AssetID", "Employee_AssetID", employee.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", employee.GroupID);
            return View(employee);
        }

        // POST: Employees1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,DepartmentID,FirstName,LastName,OfficeLocation,GroupID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName", employee.DepartmentID);
            ViewBag.EmployeeID = new SelectList(db.Employee_Assets, "Employee_AssetID", "Employee_AssetID", employee.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", employee.GroupID);
            return View(employee);
        }

        // GET: Employees1/Delete/5
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

        // POST: Employees1/Delete/5
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
