using KiemTraThu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KiemTraThu.Controllers
{
    public class Thanh0702_63131268Controller : Controller
    {
        // GET: Thanh0702_63131268
        public Model_63131268 db = new Model_63131268();

        // GET: Thanh0702_63131268/GioiThieu
        public ActionResult GioiThieu_63131268()
        {
            return View();
        }

        // GET: Thanh0702_63131268/Index
        public ActionResult Index()
        {
            return View(db.SinhViens.ToList());
        }


        // GET: Thanh0702_63131268/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: Thanh0702_63131268/Create
        public ActionResult Create()
        {
            ViewBag.MaLop = new SelectList(db.Lops, "MaLop", "TenLop");
            return View();
        }

        // POST: Thanh0702_63131268/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,HoSV,TenSV,NgaySinh,GioiTinh,AnhSV,DiaChi,MaLop")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhViens.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLop = new SelectList(db.Lops, "MaLop", "TenLop", sinhVien.MaLop);
            return View(sinhVien);
        }
        public ActionResult TimKiem()
        {
            string maSV = Request.Form["maSV"];
            string tenSV = Request.Form["tenSV"];

            var sinhViens = db.SinhViens.Where(s => s.MaSV.Contains(maSV) || s.HoSV.Contains(tenSV) || s.TenSV.Contains(tenSV)).ToList();

            return View(sinhViens);
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
