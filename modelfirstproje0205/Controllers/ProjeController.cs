using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modelfirstproje0205.Models;

namespace modelfirstproje0205.Controllers
{
    public class ProjeController : Controller
    {
      
        
            // GET: Personel
            Model1Container db = new Model1Container();
            public ActionResult List()
            {
                return View(db.ProjeSet.ToList());
            }

            [HttpGet]
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(Proje projeler)
            {
                db.ProjeSet.Add(projeler);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            [HttpGet]
            public ActionResult Edit(int id)
            {
                var duzenle = db.ProjeSet.Where(X => X.ProjeNo == id).FirstOrDefault();
                return View(duzenle);
            }
            [HttpPost]
            public ActionResult Edit(int id, Proje projeler)
            {
                db.Entry(projeler).State = System.Data.Entity.EntityState.Modified; db.SaveChanges();
                return RedirectToAction("List");
            }
            [HttpGet]
            public ActionResult Delete(int id)
            {
                var sil = db.ProjeSet.Where(X => X.ProjeNo == id).FirstOrDefault();
                return View(sil);
            }
            public ActionResult Delete(int id, Proje projeler)
            {
                projeler = db.ProjeSet.Where(X => X.ProjeNo == id).FirstOrDefault();
                db.ProjeSet.Remove(projeler);
                db.SaveChanges();
                return RedirectToAction("List");
            }
        }
}