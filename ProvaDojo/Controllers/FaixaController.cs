using ProvaDojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaDojo.Controllers
{
    public class FaixaController : Controller
    {
        private ApplicationDbContext _context;
        public FaixaController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Faixa
        public ActionResult Index()
        {
            var faixas = _context.Faixas.ToList();
            return View(faixas);
        }
        public ActionResult Details(int id)
        {
            var faixa = _context.Faixas.SingleOrDefault(f => f.id == id);
            if (faixa == null)
            {
                return HttpNotFound();
            }

            return View(faixa);
        }
    }
}