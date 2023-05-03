using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modelfirstproje0205.Models;


namespace modelfirstproje0205.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Model1Container db = new Model1Container();
        public ActionResult List()
        {
            return View(db.PersonelSet.ToList());
        }
       
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Personel personeller)
        {
            db.PersonelSet.Add(personeller);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var duzenle = db.PersonelSet.Where(X => X.PersonelNo == id).FirstOrDefault();
            return View(duzenle);
        }
        [HttpPost]
        public ActionResult Edit(int id, Personel personeller)
        {
            db.Entry(personeller).State = System.Data.Entity.EntityState.Modified; db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var sil = db.PersonelSet.Where(X => X.PersonelNo == id).FirstOrDefault();
            return View(sil);
        }
        public ActionResult Delete(int id, Personel personeller)
        {
            personeller = db.PersonelSet.Where(X => X.PersonelNo == id).FirstOrDefault();
            db.PersonelSet.Remove(personeller);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}