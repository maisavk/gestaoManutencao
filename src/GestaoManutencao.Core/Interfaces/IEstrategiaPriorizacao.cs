using GestaoManutencao.Core.Domain;
using GestaoManutencao.Core.Enums;

namespace GestaoManutencao.Core.Interfaces
{
    public interface IEstrategiaPriorizacao
    {
        Prioridade DeterminarPrioridade(SolicitacaoManutencao solicitacao);
    }
}
