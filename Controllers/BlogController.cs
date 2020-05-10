using PrivateBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PrivateBlog.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext(); 
        UserContext userdb = new UserContext();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.db.ToList());
        }

        //Get : Create Blog
        public ActionResult CreateBlog(string username,string password)
        {
            if(username == null || password == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usr = userdb.UserDb.Where(User => User.UserName == username && User.Password == password);
            if(usr == null)
            {
                return RedirectToAction("CreateUser");
            }
            return View();
        }

        //Post : Create Blog
        [HttpPost]
        public ActionResult CreateBlog([Bind(Include = "BlogName,BlogContext")] Blogs blogs)
        {
            if (ModelState.IsValid)
            {
                blogs.date = DateTime.Today;
                db.db.Add(blogs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogs);
        }
        //Get : CreateUser
        public ActionResult CreateUser()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CreateUser([Bind(Include ="UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                user.RegisterDate = DateTime.Now;
                userdb.UserDb.Add(user);
                userdb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        public ActionResult BlogDetails(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blogs blogs = db.db.Find(id);
            if(blogs == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            return View(blogs);
        }
    }
}