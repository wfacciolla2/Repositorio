using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Exceptions
{
    public class UsuarioJaCadastradoException : Exception
    {
    public UsuarioJaCadastradoException()
        :   base("Usuário já cadastrado")
        { }
    }
}
