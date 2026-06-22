using System;

namespace GestaoManutencao.Core.Exceptions
{
    public class TecnicoIncompativelException : Exception
    {
        public TecnicoIncompativelException(string message) : base(message) { }
    }
}
