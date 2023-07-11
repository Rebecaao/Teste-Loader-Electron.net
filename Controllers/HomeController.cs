using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using loader_thales.Models;
using loader_thales.Data;

namespace loader_thales.Controllers;

public class HomeController : Controller
    {
        readonly private ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
    }

