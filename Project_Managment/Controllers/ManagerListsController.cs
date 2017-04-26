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

        // GET: ManagerListsTable
        public ActionResult Index()
        {
            var managerLists = db.ManagerLists;
            return View(managerLists.ToList());
        }

        // GET: ManagerListsTable/Details/5
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

        // GET: ManagerListsTable/Create
        public ActionResult Create()
        {
            ViewBag.ManagerListID = new SelectList(db.Assets, "AssetID", "AssetDescription");
            ViewBag.EmployeeID = new SelectList(db.Employees.Where(x => x.GroupID == 1), "EmployeeID", "FirstName");
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName");
            return View();
        }

        // POST: ManagerListsTable/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManagerListID,EmployeeID,GroupID")] ManagerList managerList)
        {
            if (ModelState.IsValid)
            {
                db.ManagerLists.Add(managerList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ManagerListID = new SelectList(db.Assets, "AssetID", "AssetDescription", managerList.ManagerListID);
            ViewBag.EmployeeID = new SelectList(db.Employees.Where(x => x.GroupID == 1), "EmployeeID", "FirstName", managerList.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // GET: ManagerListsTable/Edit/5
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
            ViewBag.ManagerListID = new SelectList(db.Assets, "AssetID", "AssetDescription", managerList.ManagerListID);
            ViewBag.EmployeeID = new SelectList(db.Employees.Where(x => x.GroupID == 1), "EmployeeID", "FirstName", managerList.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // POST: ManagerListsTable/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManagerListID,EmployeeID,GroupID")] ManagerList managerList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(managerList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ManagerListID = new SelectList(db.Assets, "AssetID", "AssetDescription", managerList.ManagerListID);
            ViewBag.EmployeeID = new SelectList(db.Employees.Where(x => x.GroupID == 1), "EmployeeID", "FirstName", managerList.EmployeeID);
            ViewBag.GroupID = new SelectList(db.Groups, "GroupID", "GroupName", managerList.GroupID);
            return View(managerList);
        }

        // GET: ManagerListsTable/Delete/5
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

        // POST: ManagerListsTable/Delete/5
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
