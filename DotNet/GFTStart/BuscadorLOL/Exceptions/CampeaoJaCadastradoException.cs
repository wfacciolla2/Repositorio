using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Exceptions
{
    public class CampeaoJaCadastradoException : Exception
    {
        public CampeaoJaCadastradoException()
            : base("Este Campeao já está cadastrado")
        { }
    }
}
