using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class JorgeSandovalFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: JorgeSandovalFriends
        public ActionResult Index()
        {
            return View(db.JorgeSandovalFriends.ToList());
        }

        // GET: JorgeSandovalFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JorgeSandovalFriend jorgeSandovalFriend = db.JorgeSandovalFriends.Find(id);
            if (jorgeSandovalFriend == null)
            {
                return HttpNotFound();
            }
            return View(jorgeSandovalFriend);
        }

        // GET: JorgeSandovalFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JorgeSandovalFriends/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,Name,Apodo,Birthday,Type")] JorgeSandovalFriend jorgeSandovalFriend)
        {
            if (ModelState.IsValid)
            {
                db.JorgeSandovalFriends.Add(jorgeSandovalFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jorgeSandovalFriend);
        }

        // GET: JorgeSandovalFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JorgeSandovalFriend jorgeSandovalFriend = db.JorgeSandovalFriends.Find(id);
            if (jorgeSandovalFriend == null)
            {
                return HttpNotFound();
            }
            return View(jorgeSandovalFriend);
        }

        // POST: JorgeSandovalFriends/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,Name,Apodo,Birthday,Type")] JorgeSandovalFriend jorgeSandovalFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jorgeSandovalFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jorgeSandovalFriend);
        }

        // GET: JorgeSandovalFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JorgeSandovalFriend jorgeSandovalFriend = db.JorgeSandovalFriends.Find(id);
            if (jorgeSandovalFriend == null)
            {
                return HttpNotFound();
            }
            return View(jorgeSandovalFriend);
        }

        // POST: JorgeSandovalFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JorgeSandovalFriend jorgeSandovalFriend = db.JorgeSandovalFriends.Find(id);
            db.JorgeSandovalFriends.Remove(jorgeSandovalFriend);
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
