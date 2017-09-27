using ProvaDojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaDojo.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;
        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: TipoDeAssociacao
        public ActionResult Index()
        {
            var tipos = _context.TipoDeAssociacoes.ToList();
            return View(tipos);
        }

        public ActionResult Details(int id)
        {
            var tipos = _context.TipoDeAssociacoes.SingleOrDefault(t => t.id == id);
            if (tipos == null)
            {
                return HttpNotFound();
            }

            return View(tipos);
        }
    }
}