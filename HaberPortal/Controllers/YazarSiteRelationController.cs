﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HaberPortal.Models;

namespace HaberPortal.Controllers
{
    public class YazarSiteRelationController : Controller
    {
        private DB090928093827Entities db = new DB090928093827Entities();

        // GET: YazarSiteRelation
        public ActionResult Index()
        {
            var tbl_PortalHaber_YazarSiteRelation = db.tbl_PortalHaber_YazarSiteRelation.Include(t => t.tbl_PortalHaber_Site).Include(t => t.tbl_PortalHaber_Yazar);
            return View(tbl_PortalHaber_YazarSiteRelation.ToList());
        }

        // GET: YazarSiteRelation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation = db.tbl_PortalHaber_YazarSiteRelation.Find(id);
            if (tbl_PortalHaber_YazarSiteRelation == null)
            {
                return HttpNotFound();
            }
            return View(tbl_PortalHaber_YazarSiteRelation);
        }

        // GET: YazarSiteRelation/Create
        public ActionResult Create()
        {
            ViewBag.SiteId = new SelectList(db.tbl_PortalHaber_Site, "Site_Id", "Site_Adi");
            ViewBag.YazarId = new SelectList(db.tbl_PortalHaber_Yazar, "YazarId", "YName");
            return View();
        }

        // POST: YazarSiteRelation/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,YazarId,SiteId")] tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation)
        {
            if (ModelState.IsValid)
            {
                db.tbl_PortalHaber_YazarSiteRelation.Add(tbl_PortalHaber_YazarSiteRelation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SiteId = new SelectList(db.tbl_PortalHaber_Site, "Site_Id", "Site_Adi", tbl_PortalHaber_YazarSiteRelation.SiteId);
            ViewBag.YazarId = new SelectList(db.tbl_PortalHaber_Yazar, "YazarId", "YName", tbl_PortalHaber_YazarSiteRelation.YazarId);
            return View(tbl_PortalHaber_YazarSiteRelation);
        }

        // GET: YazarSiteRelation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation = db.tbl_PortalHaber_YazarSiteRelation.Find(id);
            if (tbl_PortalHaber_YazarSiteRelation == null)
            {
                return HttpNotFound();
            }
            ViewBag.SiteId = new SelectList(db.tbl_PortalHaber_Site, "Site_Id", "Site_Adi", tbl_PortalHaber_YazarSiteRelation.SiteId);
            ViewBag.YazarId = new SelectList(db.tbl_PortalHaber_Yazar, "YazarId", "YName", tbl_PortalHaber_YazarSiteRelation.YazarId);
            return View(tbl_PortalHaber_YazarSiteRelation);
        }

        // POST: YazarSiteRelation/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,YazarId,SiteId")] tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_PortalHaber_YazarSiteRelation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SiteId = new SelectList(db.tbl_PortalHaber_Site, "Site_Id", "Site_Adi", tbl_PortalHaber_YazarSiteRelation.SiteId);
            ViewBag.YazarId = new SelectList(db.tbl_PortalHaber_Yazar, "YazarId", "YName", tbl_PortalHaber_YazarSiteRelation.YazarId);
            return View(tbl_PortalHaber_YazarSiteRelation);
        }

        // GET: YazarSiteRelation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation = db.tbl_PortalHaber_YazarSiteRelation.Find(id);
            if (tbl_PortalHaber_YazarSiteRelation == null)
            {
                return HttpNotFound();
            }
            return View(tbl_PortalHaber_YazarSiteRelation);
        }

        // POST: YazarSiteRelation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_PortalHaber_YazarSiteRelation tbl_PortalHaber_YazarSiteRelation = db.tbl_PortalHaber_YazarSiteRelation.Find(id);
            db.tbl_PortalHaber_YazarSiteRelation.Remove(tbl_PortalHaber_YazarSiteRelation);
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
