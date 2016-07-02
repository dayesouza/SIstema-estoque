using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class MovimentacaoController : Controller
    {
        // GET: Movimentacao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movimentacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movimentacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movimentacao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movimentacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movimentacao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movimentacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movimentacao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
