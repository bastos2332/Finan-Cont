using Finan_Control.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finan_Control.DAO
{
    public class UsuarioDAO

    {

        public FinanContext Context { get; set; }

        public UsuarioDAO(FinanContext context)
        {
            this.Context = context;
        }
        public void Adiciona(Usuario usuario)
        {
            Context.Usuarios.Add(usuario);
            Context.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return Context.Usuarios.ToList();
        }
    }
}