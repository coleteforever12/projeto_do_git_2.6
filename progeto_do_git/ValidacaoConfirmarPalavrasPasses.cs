using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progeto_do_git
{
    internal class ValidacaoConfirmarPalavrasPasses : Exception
    {
        internal ValidacaoConfirmarPalavrasPasses(string message) : base(message)
        {

        }

    }
}
