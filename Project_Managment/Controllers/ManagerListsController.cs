using System;
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
    public class ManagerListsController : Controller
    {
        private AccessDbContext db = new AccessDbContext();

        // GET: ManagerLists
        public ActionResult Index()
        {
            var managerLists = db.ManagerLists;
            return View(managerLists.ToList());
        }

        // GET: ManagerLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerList managerList = db.ManagerLists.Find(id);
            if (managerList == null)
            {
                return HttpNotFound();
            }
            return View(managerList);
        }

        // GET: ManagerLists/Create
        public ActionResult Create()
        {
            ViewBag.AssetID = new SelectList(db.Assets, "AssetID", "ComputerName");
            ViewBag.EmployeeID = new SelectList(db.Employees.Where(e => e.GroupID == 1), "EmployeeID", "FirstName");
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName");
            return View();
        }

        // POST: ManagerLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeeID,GroupID,AssetID")] ManagerList managerList)
        {
            if (ModelState.IsValid)
            {
                db.ManagerLists.Add(managerList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssetID = new SelectList(db.Assets, "AssetID", "ComputerName", managerList.AssetID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", managerList.Employees.GroupID==1);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // GET: ManagerLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerList managerList = db.ManagerLists.Find(id);
            if (managerList == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssetID = new SelectList(db.Assets, "AssetID", "ComputerName", managerList.AssetID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", managerList.Employees.GroupID == 1);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // POST: ManagerLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeeID,GroupID,AssetID")] ManagerList managerList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(managerList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssetID = new SelectList(db.Assets, "AssetID", "ComputerName", managerList.AssetID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "FirstName", managerList.Employees.GroupID == 1);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // GET: ManagerLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagerList managerList = db.ManagerLists.Find(id);
            if (managerList == null)
            {
                return HttpNotFound();
            }
            return View(managerList);
        }

        // POST: ManagerLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManagerList managerList = db.ManagerLists.Find(id);
            db.ManagerLists.Remove(managerList);
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
