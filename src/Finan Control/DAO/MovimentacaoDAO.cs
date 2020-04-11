using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Finan_Control.Entidades;
namespace Finan_Control.DAO
{
    public class MovimentacaoDAO
    {
        private FinanContext Context { get; set; }
        public MovimentacaoDAO(FinanContext context)
        {
            this.Context = context;
        }

        public void Adicionar(Movimentacao movimentacao)
        {
            Context.Movimentacoes.Add(movimentacao);
            Context.SaveChanges();
        }

        public IList<Movimentacao> Listar()
        {
            return Context.Movimentacoes.ToList();
        }

    }
}