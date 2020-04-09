using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finan_Control.Entidades
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoMovimentacao TipoMovimentracao { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}