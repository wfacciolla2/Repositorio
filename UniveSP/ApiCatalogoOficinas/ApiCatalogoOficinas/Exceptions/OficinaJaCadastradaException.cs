using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Exceptions
{
    public class OficinaJaCadastradaException : Exception
    {
        public OficinaJaCadastradaException()
            : base("Esta Oficina já esta cadastrada")
        { }
    }
}
