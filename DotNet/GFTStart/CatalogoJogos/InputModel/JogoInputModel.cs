using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [Range(1,1000,ErrorMessage ="O preço deve ser de no minimo R$1,00 e no maximo R$1.000,00")]
        public double Preco { get; set; }
    }
}
