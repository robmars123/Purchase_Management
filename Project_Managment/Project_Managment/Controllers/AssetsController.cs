using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_Managment.Models;
using PagedList;
using PagedList.Mvc;

namespace Project_Managment.Controllers
{
    public class AssetsController : Controller
    {
        private AccessDbContext db = new AccessDbContext();
        private bool x;

        public int? id { get; private set; }





       





        // GET: Assets
        public ActionResult Index(string option, string search, int? page)
        {
            if (option == null)
            {
                var g = from s in db.Assets
                        join sa in db.Employees on s.EmployeeID equals sa.EmployeeID
                        where s.EmployeeID != null && sa.LastName != null
                        select s;

                return View(g.ToList().ToPagedList(page ?? 1, 6));
            }
            //     //Search Bar
            //if a user choose the radio button option as Subject  
             else if (option == "Make")
          //  if (option == "Make")
            {
                    //Index action method will return a view with a student records based on what a user specify the value in textbox  
                    return View(db.Assets.Where(x => x.Make == search || x.Make.StartsWith(search) && x.Employees.LastName != null).ToList().ToPagedList( page ?? 1, 6));
                }
                else if (option == "Department")
                {
                    return View
                        (
                        db.Assets.Where(x => x.Department.DepartmentName == search ||
                    search == null || x.Department.DepartmentName.StartsWith(search)).ToList().ToPagedList(page ?? 1, 6)
                         );
                }
                else
                {
                    return View(db.Assets.Where(x => x.Employees.FirstName.StartsWith(search) || x.Employees.FirstName == search
                    || x.Employees.LastName == search || x.Employees.LastName.StartsWith(search)).ToList().ToPagedList(page ?? 1, 6));
                }
            
            


            
         


            // Search Bar End



            //var courses = db.Assets.Include(c => c.Employees);
            ////filter out nulls.

            //  return View(db.Assets.ToList());







            //  return View(courses.ToList());


            // return View(db.Assets.ToList());
            // return View();
        }



        //private ActionResult View(object p)
        //{
        //    throw new NotImplementedException();
        //}

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
