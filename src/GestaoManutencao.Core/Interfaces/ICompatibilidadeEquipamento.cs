using GestaoManutencao.Core.Domain;
using GestaoManutencao.Core.Domain.Equipamentos;

namespace GestaoManutencao.Core.Interfaces
{
    public interface ICompatibilidadeEquipamento
    {
        bool Validar(Tecnico tecnico, Equipamento equipamento);
    }
}
