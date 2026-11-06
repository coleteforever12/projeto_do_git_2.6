using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progeto_do_git
{
    internal class ValidacaoUserNameException : Exception
    {
        internal ValidacaoUserNameException(string message) : base(message)
        {

        }
    }
}
