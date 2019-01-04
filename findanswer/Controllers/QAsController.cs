using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using findanswer.Models;

namespace findanswer.Controllers
{
    public class QAsController : Controller
    {
        //对于web.config中不存放connectstring的处理
        private FindAnswerMsSqlModel db = new FindAnswerMsSqlModel("server=172.26.7.8;database=DB_FindAnswer;user=sa;pwd=mi123456");

        // GET: QAs
        public ActionResult Index()
        {
            return View(db.QA.ToList());
        }

        // GET: QAs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QA.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // GET: QAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Question,Id,Q_Content,Q_Type,Answer,Analysis,Cat_Id,Add_Time,Img_Path,Flag,Weight,From_Source,Add_Name,For_Exame,Q_Md5")] QA qA)
        {
            if (ModelState.IsValid)
            {
                db.QA.Add(qA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qA);
        }

        // GET: QAs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QA.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // POST: QAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Question,Id,Q_Content,Q_Type,Answer,Analysis,Cat_Id,Add_Time,Img_Path,Flag,Weight,From_Source,Add_Name,For_Exame,Q_Md5")] QA qA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qA);
        }

        // GET: QAs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QA.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // POST: QAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QA qA = db.QA.Find(id);
            db.QA.Remove(qA);
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
