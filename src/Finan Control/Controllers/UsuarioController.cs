using Finan_Control.DAO;
using Finan_Control.Entidades;
using Finan_Control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

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

        public ActionResult Adiciona(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    WebSecurity.CreateUserAndAccount(usuarioModel.Nome, usuarioModel.Senha, new { Email = usuarioModel.Email });
                    return RedirectToAction("Index");
                }
                catch (MembershipCreateUserException ex)
                {
                    ModelState.AddModelError("Usuario.Invalido", ex.Message);
                    return View("Form", usuarioModel);
                }
            }
            else
            {
                return RedirectToAction("Form", usuarioModel);
            }
        }
    }
}