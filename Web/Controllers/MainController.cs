using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Web.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        // GET: Main/Details/5
        public ActionResult Details(int sku)
        {
            Repository.ProdRepository ProdRepo = new Repository.ProdRepository();

            return View(ProdRepo.GetProducts().Find(Prod => Prod.sku == sku));
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Employee/EditEmpDetails/5    
        public ActionResult EditProducts(int sku)
        {
            Repository.ProdRepository ProdRepo = new Repository.ProdRepository();

            return View(ProdRepo.GetProducts().Find(Prod => Prod.sku == sku));

        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(Models.ProdutoModel obj)
        {
            try
            {
                Repository.ProdRepository repositorio = new Repository.ProdRepository();
                repositorio.AddProducts(obj);
                return RedirectToAction("GetProducts");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("FalhaAdd", "Houve um erro de conexão, tente mais tarde!");
                return View();
            }
        }

    public ActionResult GetProducts()
    {
        Repository.ProdRepository ProdRepo = new Repository.ProdRepository();
        ModelState.Clear();
        return View(ProdRepo.GetProducts());
    }
    // GET: Employee/AddEmployee    
    public ActionResult AddProducts()
    {
        return View();
    }

    // POST: Employee/EditEmpDetails/5    
    [HttpPost]

    public ActionResult EditProducts(int sku, Models.ProdutoModel obj)
    {
        try
        {
                Repository.ProdRepository ProdRepo = new Repository.ProdRepository();

                ProdRepo.UpdateProducts(obj);

            return RedirectToAction("GetProducts");
        }
        catch
        {
            return View();
        }
    }

    // GET: Employee/DeleteEmp/5    
    public ActionResult DeleteProduct(int sku)
    {
        try
        {
            Repository.ProdRepository ProdRepo = new Repository.ProdRepository();
            if (ProdRepo.DeleteProducts(sku))
            {
                ViewBag.AlertMsg = "Produto excluído com sucesso!";
            }
            return RedirectToAction("GetProducts");
        }
        catch
        {
            return View();
        }
    }
    }

}
