using Microsoft.AspNetCore.Mvc;
using ManageSmart.Data;
using ManageSmart.Models;

namespace ManageSmart.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // LISTAR
        public IActionResult Index()
        {
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }

        // FORM CREATE
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // EDIT FORM
        public IActionResult Edit(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            return View(usuario);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}