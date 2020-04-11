using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Finan_Control.DAO;
using Finan_Control.Entidades;

namespace Finan_Control.Controllers
{
    [Authorize]
    public class MovimentacaoController : Controller
    {
        private MovimentacaoDAO MovimentacaoDAO { get; set; }

        private UsuarioDAO UsuarioDAO { get; set; }

        public MovimentacaoController(MovimentacaoDAO movimentacaoDAO, UsuarioDAO usuarioDAO)
        {
            this.MovimentacaoDAO = movimentacaoDAO;
            this.UsuarioDAO = usuarioDAO;
        }

        public ActionResult Index()
        {
            List<Movimentacao> movimetacoes = new List<Movimentacao>();
            return View(movimetacoes);
        }

        public ActionResult Form()
        {
            ViewBag.Usuarios = UsuarioDAO.Lista();
            return View();
        }

        public ActionResult Adiciona(Movimentacao movimentacao)
        {

            this.MovimentacaoDAO.Adicionar(movimentacao);
            return RedirectToAction("Index");
        }
    }
}