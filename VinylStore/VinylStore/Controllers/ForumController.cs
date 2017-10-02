using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VinylStore.Data_Access_Layer;
using VinylStore.Models;

namespace VinylStore.Controllers
{
    public class ForumController : Controller
    {
        private VinylContext db = new VinylContext();

        // GET: Forum
        public ActionResult Index()
        {
            return View(db.ForumTopics.ToList());
        }

        public ActionResult ViewTopic(ForumTopic Topic)
        {
            ViewBag.Subject = Topic.Subject;
            //var postsList = db.ForumPosts.Where(x => x.Subject == Topic.Subject ).OrderBy(x=> x.CreationDate).ToList();
            IEnumerable postsList = from x in db.ForumPosts
                                   where x.Subject == Topic.Subject
                                   orderby x.CreationDate
                                   select x;
            return View(postsList);
        }

        public ActionResult AddPost(string postContent, string TopicSubject)
        {
            
            return null;
        }
        // GET: Forum/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForumPost forumPost = db.ForumPosts.Find(id);
            if (forumPost == null)
            {
                return HttpNotFound();
            }
            return View(forumPost);
        }
        

        // POST: Forum/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost([Bind(Include = "Id,Author,Content,CreationDate")] ForumPost forumPost)
        {
            if (ModelState.IsValid)
            {
                db.ForumPosts.Add(forumPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(forumPost);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTopic(string Subject, string Autor, DateTime CreationDate, ForumTopic forumTopic)
        {
            if (ModelState.IsValid)
            {
                if (forumTopic.Id == 0)
                    forumTopic.Id = 1;

                /*forumTopic.Autor = Autor;
                forumTopic.CreationDate = CreationDate;
                forumTopic.Subject = Subject;*/
                db.ForumTopics.Add(forumTopic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        // GET: Forum/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForumPost forumPost = db.ForumPosts.Find(id);
            if (forumPost == null)
            {
                return HttpNotFound();
            }
            return View(forumPost);
        }

        // POST: Forum/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Author,Content,CreationDate")] ForumPost forumPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(forumPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(forumPost);
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ForumPost forumPost = db.ForumPosts.Find(id);
            if (forumPost == null)
            {
                return HttpNotFound();
            }
            return View(forumPost);
        }

        // POST: Forum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ForumPost forumPost = db.ForumPosts.Find(id);
            db.ForumPosts.Remove(forumPost);
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
