using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progeto_do_git
{
    internal class ValidacaoConfirmarPalavrasPasseException : Exception
    {
        internal ValidacaoConfirmarPalavrasPasseException(string message) : base(message)
        {
        }
    }
}
