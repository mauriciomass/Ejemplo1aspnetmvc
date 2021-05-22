using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejemplo1aspnetmvc.Models;

namespace Ejemplo1aspnetmvc.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            using (var db = new inventario2021Entities())
            {
                return View(db.usuario.ToList());
            }
        }
    }
}