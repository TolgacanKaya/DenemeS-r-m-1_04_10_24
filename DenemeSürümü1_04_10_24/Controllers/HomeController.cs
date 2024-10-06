using DenemeSürümü1_04_10_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenemeSürümü1_04_10_24.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            context db = new context();
            //var List = db.Urunler.ToList();
            var list = db.Urunler.Select(p => new Urun
            {
                Fiyat = p.Fiyat,
                KategoriAd = p.Kategoriler.CategoryName,
                Marka = p.Marka,
                Stok = p.Stok,
                UrunAD = p.UrunAD,
                KategoriID = p.KategoriID,
                UrunID = p.UrunID
            }).ToList();
            return View(list);
        }
    }
}