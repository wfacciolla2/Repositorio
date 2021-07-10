using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.ViewModel
{
    public class CampeaoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public float Preco { get; set; }
    }
}
