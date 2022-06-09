using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.ViewModel
{
    public class OficinaViewModel
    {
        public Guid Id { get; set; } //Id gerado automaticamente
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public double Estrelas { get; set; }
    }
}
