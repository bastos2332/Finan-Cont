using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finan_Control.Models
{
    public class UsuarioModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Compare("Senha"), Required]
        public string ConfirmacaoSenha { get; set; }
    }
}