using System;

namespace GestaoManutencao.Core.Exceptions
{
    public class TransicaoEstadoInvalidaException : Exception
    {
        public TransicaoEstadoInvalidaException(string message) : base(message) { }
    }
}
