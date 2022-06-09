using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.InputModel
{
    public class OficinaInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Nome da Oficina deve conter entre 5 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O Endereço da Oficina deve conter entre 20 e 200 caracteres")]
        public string Endereco { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 25, ErrorMessage = "A Descrição da Oficina deve conter entre 25 e 1000 caracteres")]
        public string Descricao { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "CNPJ invalido")]
        public string Cnpj { get; set; }
        public double Estrela { get; internal set; }
    }
}
