using Finan_Control.DAO;
using Finan_Control.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finan_Control.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO UsuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.UsuarioDAO = usuarioDAO;
        }

        public ActionResult Index()
        {
            return View(UsuarioDAO.Lista());
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                UsuarioDAO.Adiciona(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Form");
            }
        }
    }
}