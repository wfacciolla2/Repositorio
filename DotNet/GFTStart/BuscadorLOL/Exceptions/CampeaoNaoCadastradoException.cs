using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Exceptions
{
    public class CampeaoNaoCadastradoException : Exception
    {
        public CampeaoNaoCadastradoException()
            : base("Este Campeao não está cadastrado")
        { }
    }
}
