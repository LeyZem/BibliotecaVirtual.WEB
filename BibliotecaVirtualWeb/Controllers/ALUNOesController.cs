using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BibliotecaVirtualWeb;

namespace BibliotecaVirtualWeb.Controllers
{
    public class ALUNOesController : Controller
    {
        private BibliotecaVirtualEntities db = new BibliotecaVirtualEntities();

        // GET: ALUNOes
        public ActionResult Index()
        {
            return View(db.ALUNO.ToList());
        }

        // GET: ALUNOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUNO aLUNO = db.ALUNO.Find(id);
            if (aLUNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUNO);
        }

        // GET: ALUNOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ALUNOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ALUNO,NOME,SOBRENOME,CPF,NASC,ENDERECO,BAIRRO,CIDADE,UF,CEP,PAIS,TEL_RES,TEL_CEL,ID_RESERVA,EMAIL")] ALUNO aLUNO)
        {
            if (ModelState.IsValid)
            {
                db.ALUNO.Add(aLUNO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aLUNO);
        }

        // GET: ALUNOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUNO aLUNO = db.ALUNO.Find(id);
            if (aLUNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUNO);
        }

        // POST: ALUNOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ALUNO,NOME,SOBRENOME,CPF,NASC,ENDERECO,BAIRRO,CIDADE,UF,CEP,PAIS,TEL_RES,TEL_CEL,ID_RESERVA,EMAIL")] ALUNO aLUNO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aLUNO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aLUNO);
        }

        // GET: ALUNOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUNO aLUNO = db.ALUNO.Find(id);
            if (aLUNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUNO);
        }

        // POST: ALUNOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ALUNO aLUNO = db.ALUNO.Find(id);
            db.ALUNO.Remove(aLUNO);
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
