using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
  public class DepositoController : Controller {
    // GET: Deposito
    public ActionResult Index() {
      return View();
    }

    // GET: Deposito/Create
    public ActionResult Create() {
      return View();
    }

    // POST: Deposito/Create
    [HttpPost]
    public ActionResult Create(Models.DepositoModel obj) {
      try {
        Repository.DepRepository repositorio = new Repository.DepRepository();
        repositorio.AddDeposito(obj);
        return RedirectToAction("Index");
      }
      catch (Exception e) {
        ModelState.AddModelError("FalhaAdd", "Houve um erro de conexão, tente mais tarde!");
        return View();
      }
    }

    public ActionResult GetDeposito() {
      Repository.DepRepository repositorio = new Repository.DepRepository();
      ModelState.Clear();
      return View(repositorio.GetDeposito());
    }

  }
}
