using GestaoManutencao.Core.Domain;

namespace GestaoManutencao.Core.Interfaces
{
    public interface ICalculoCustoStrategy
    {
        decimal Calcular(SolicitacaoManutencao solicitacao);
    }
}
