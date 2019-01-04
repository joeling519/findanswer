using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using findanswer.Models;
using findanswer.Controllers;

namespace findanswer.Controllers
{
    public class FirstPageController : Controller
    {

        //对于web.config中不存放connectstring的处理
        private FindAnswerMsSqlModel db = new FindAnswerMsSqlModel("server=172.26.7.8;database=DB_FindAnswer;user=sa;pwd=mi123456");
        
        // GET: FirstPage
        public ActionResult Default()
        {
            ViewBag.Message = "帮助您在这里找到你需要的考试答案.";

            //findanswer.Models.FirstPageModel test = new findanswer.Models.FirstPageModel();
            //string a = test.a.ToString();
            //ViewBag.Message = a;

            //return View();
            return View(db.Cat.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "帮助您在这里找到你需要的考试答案.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "帮助您在这里找到你需要的考试答案.";

            return View();
        }

        public ActionResult ClickList(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Cat cat = db.Cat.Find(id);
            //if (cat == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }


    }
}