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
    public class AssetsController : Controller
    {
        private AccessDbContext db = new AccessDbContext();

        public int? id { get; private set; }





       





        // GET: Assets
        public ActionResult Index()
        {

            



            var courses = db.Assets.Include(c => c.Employees);
            //filter out nulls.
            var g = from s in db.Assets
                    join sa in db.Employees on s.EmployeeID equals sa.EmployeeID
                    where s.EmployeeID != null && sa.LastName != null
                    select s;

            return View(g);






          //  return View(courses.ToList());


            // return View(db.Assets.ToList());
            // return View();
        }

        private ActionResult View(List<Employee> list1, List<Asset> list2)
        {
            throw new NotImplementedException();
        }

        // GET: Assets/Details/5
        public ActionResult Details(int? id)
        {

          //  List<Asset> assets = db.Assets.Where(s => s.AssetID == id);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // GET: Assets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssetID,AssetDescription,EmployeeID,AssetCategoryID,StatusID,DepartmentID,VendorID,Make,ModelNumber,SerialNumber,DateAcquired,DateSold,PurchasePrice,DepreciationMethod,DepreciableLife,SalvageValue,CurrentValue,Comments,Description,NextSchedMaint,Processor,RAM,Condition,ComputerName,SSMA_TimeStamp")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Assets.Add(asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asset);
        }

        // GET: Assets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // POST: Assets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssetID,AssetDescription,EmployeeID,AssetCategoryID,StatusID,DepartmentID,VendorID,Make,ModelNumber,SerialNumber,DateAcquired,DateSold,PurchasePrice,DepreciationMethod,DepreciableLife,SalvageValue,CurrentValue,Comments,Description,NextSchedMaint,Processor,RAM,Condition,ComputerName,SSMA_TimeStamp")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asset);
        }

        // GET: Assets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // POST: Assets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asset asset = db.Assets.Find(id);
            db.Assets.Remove(asset);
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
