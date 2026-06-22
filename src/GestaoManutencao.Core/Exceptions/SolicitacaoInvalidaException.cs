using System;

namespace GestaoManutencao.Core.Exceptions
{
    public class SolicitacaoInvalidaException : Exception
    {
        public SolicitacaoInvalidaException(string message) : base(message) { }
    }
}
