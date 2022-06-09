﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.ViewModel
{
    public class OficinaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
        public double Estrelas { get; set; }
    }
}
