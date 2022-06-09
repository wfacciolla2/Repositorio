using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Exceptions
{
    public class OficinaNaoCadastradaException : Exception
    {
        public OficinaNaoCadastradaException()
            : base("Oficina não cadastrada")
        { }
    }
}
