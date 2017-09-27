using ProvaDojo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ProvaDojo.Controllers
{
    public class AlunoController : Controller
    {
        private ApplicationDbContext _context;
        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Aluno
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Include(f => f.Faixa).Include(t => t.TipoDeAssociacao).ToList();
            return View(alunos);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.Include(f=>f.Faixa).Include(t=>t.TipoDeAssociacao).SingleOrDefault(a => a.id == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }
    }
}