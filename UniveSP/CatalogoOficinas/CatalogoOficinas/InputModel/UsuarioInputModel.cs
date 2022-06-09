using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.InputModel
{
    public class UsuarioInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Nome deve conter entre 5 e 100 caracteres")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Nasc { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }
    }
}
