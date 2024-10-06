﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenemeSürümü1_04_10_24.Controllers
{
    public class KategoriController : Controller
    {
        public ActionResult Index()
        {
            context db = new context();
            var kategoriler = db.Kategoriler.ToList();
            return View(kategoriler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {

            return View();
        }
        [HttpPost]

        public ActionResult KategoriEkle(string KategoriAd)
        {
            context db = new context();
            db.Kategoriler.Add(new Kategoriler
            {
                CategoryName = KategoriAd,
            });
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}