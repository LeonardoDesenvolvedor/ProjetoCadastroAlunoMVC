using CadastroAluno.Contexts;
using CadastroAluno.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CadastroAluno.Controllers
{
    public class CadastroController : Controller
    {

        private EFContext context = new EFContext();
 

        // GET: Cadastro Index
        public ActionResult Index()
        {
            return View(context.Cadastros.OrderBy(a => a.Nome));
        }


        // Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cadastro cadastro)
        {
            context.Cadastros.Add(cadastro);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        // Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = context.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cadastro).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro);
        }


        // Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = context.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }


        // Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = context.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Cadastro cadastro = context.Cadastros.Find(id);
            context.Cadastros.Remove(cadastro);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}