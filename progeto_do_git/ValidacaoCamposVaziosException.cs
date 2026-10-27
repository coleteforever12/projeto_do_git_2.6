using System;

namespace projeto_do_git
{
    internal class ValidacaoCamposVaziosException : Exception
    {
        internal ValidacaoCamposVaziosException(string message) : base(message)
        {
        }
    }
}