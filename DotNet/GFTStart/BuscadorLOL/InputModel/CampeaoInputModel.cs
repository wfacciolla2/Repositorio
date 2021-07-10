using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.InputModel
{
    public class CampeaoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do Campeao deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "A função do Campeao deve ter entre 3 e 15 caracteres")]
        public string Funcao { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public float Preco { get; set; }
    }
}
