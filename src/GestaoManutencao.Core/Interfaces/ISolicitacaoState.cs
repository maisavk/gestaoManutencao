using GestaoManutencao.Core.Domain;

namespace GestaoManutencao.Core.Interfaces
{
    public interface ISolicitacaoState
    {
        string Nome { get; };
        void AtribuirTecnico(SolicitacaoManutencao solicitacao, Tecnico tecnico);
        void AdicionarServico(SolicitacaoManutencao solicitacao, ServicoRealizado servico);
        void Avancar(SolicitacaoManutencao solicitacao);
        void Cancelar(SolicitacaoManutencao solicitacao, string justificativa);
    }
}
