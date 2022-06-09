using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Exceptions
{
    public class OficinaNaoCadastradaException : Exception
    {
        public OficinaNaoCadastradaException()
            : base("Esta Oficina não esta cadastrada")
        { }
    }
}
