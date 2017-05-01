using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dapper;
using Project_Managment.Models;
using PagedList;
using PagedList.Mvc;

namespace Project_Managment.Controllers
{
    public class InvoicesController : Controller
    {
        private AccessDbContext db = new AccessDbContext();

        // GET: Invoices
        public ActionResult Index()
        {
            return View(db.Invoices.ToList());
        }

        // GET: Invoices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoices.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }

            return View(invoice);
        }

        // GET: Invoices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Firm_Invoice,Case_Name,Status,Invoice_Date,Appealable_Items,Total_Billed,pdf")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                db.Invoices.Add(invoice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(invoice);
        }

        // GET: Invoices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoices.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Firm_Invoice,Case_Name,Status,Invoice_Date,Appealable_Items,Total_Billed,pdf")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invoice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(invoice);
        }

        // GET: Invoices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoices.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Invoice invoice = db.Invoices.Find(id);
            db.Invoices.Remove(invoice);
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
        #region Upload Download file
        public ActionResult FileUpload()
        {
            return View();
        }


        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase files)
        {

            String FileExt = Path.GetExtension(files.FileName).ToUpper();

            if (FileExt == ".PDF")
            {
                Stream str = files.InputStream;
                BinaryReader Br = new BinaryReader(str);
                Byte[] FileDet = Br.ReadBytes((Int32)str.Length);

                FileDetailsModel Fd = new Models.FileDetailsModel();
                Fd.Case_Name = files.FileName;
                Fd.pdf = FileDet;
                SaveFileDetails(Fd);
                return RedirectToAction("FileUpload");
            }
            else
            {

                ViewBag.FileStatus = "Invalid file format.";
                return View();

            }

        }

        [HttpGet]
        public FileResult DownLoadFile(int id)
        {


            List<FileDetailsModel> ObjFiles = GetFileList();

            var FileById = (from FC in ObjFiles
                            where FC.Id.Equals(id)
                            select new { FC.Case_Name, FC.pdf }).ToList().FirstOrDefault();

            return File(FileById.pdf, "application/pdf", FileById.Case_Name);

        }
        #endregion

        #region View Uploaded files
        [HttpGet]
        public PartialViewResult FileDetails()
        {
            List<FileDetailsModel> DetList = GetFileList();

            return PartialView("FileDetails", DetList);


        }
        private List<FileDetailsModel> GetFileList()
        {
            List<FileDetailsModel> DetList = new List<FileDetailsModel>();

            DbConnection();
            con.Open();
            DetList = SqlMapper.Query<FileDetailsModel>(con, "GetFileDetails", commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return DetList;
        }

        #endregion

        #region Database related operations
        private void SaveFileDetails(FileDetailsModel objDet)
        {

            DynamicParameters Parm = new DynamicParameters();
            Parm.Add("@FileName", objDet.Case_Name);
            Parm.Add("@FileContent", objDet.pdf);
            DbConnection();
            con.Open();
            con.Execute("AddFileDetails", Parm, commandType: System.Data.CommandType.StoredProcedure);
            con.Close();


        }
        #endregion

        #region Database connection

        private SqlConnection con;
        private string constr;
        private void DbConnection()
        {
            constr = ConfigurationManager.ConnectionStrings["AccessDbContext"].ToString();
            con = new SqlConnection(constr);

        }
        #endregion
    }
}
